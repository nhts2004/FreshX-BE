using System.Text;
using System.Text.Json.Serialization;
using API;
using API.EmailAotu;
using API.Hubs;
using API.Interfaces;
using API.Server.Interfaces;
using API.Server.Services;
using API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Quartz;
using Quartz.Impl;
using Quartz.Spi;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Database
        var connectionString = builder.Configuration.GetConnectionString("DbContext");

        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString)
        );

        // JWT Authentication
        var jwtSettings = builder.Configuration.GetSection("Jwt");

        var secretKey = jwtSettings["Key"]
            ?? throw new InvalidOperationException("JWT Key is missing");

        var issuer = jwtSettings["Issuer"];
        var audience = jwtSettings["Audience"];

        var key = Encoding.ASCII.GetBytes(secretKey);

        builder.Services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = issuer,
                ValidAudience = audience,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ClockSkew = TimeSpan.Zero
            };
        });

        // Services
        builder.Services.AddSingleton<IJwtTokenService, JwtTokenService>();

        builder.Services.AddScoped<IRoleService, RoleService>();
        builder.Services.AddScoped<IAccountEmpService, AccountEmpService>();
        builder.Services.AddScoped<IChatMessageService, ChatMessageService>();
        builder.Services.AddScoped<IChatSessionService, ChatSessionService>();
        builder.Services.AddScoped<IAppointmentService, AppointmentService>();
        builder.Services.AddScoped<IAccountCusService, AccountCusService>();
        builder.Services.AddScoped<IMedicalRecordService, MedicalRecordService>();
        builder.Services.AddScoped<IFeedbackService, FeedbackService>();

        builder.Services.AddHttpClient();

        // Controllers & JSON
        builder.Services
            .AddControllers()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                options.JsonSerializerOptions.WriteIndented = true;
            });

        // AutoMapper
        builder.Services.AddAutoMapper(cfg =>
        {
            cfg.AddMaps(AppDomain.CurrentDomain.GetAssemblies());
        });

        // SignalR
        builder.Services.AddSignalR();

        // CORS
        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowAll", policy =>
                policy.AllowAnyOrigin()
                      .AllowAnyMethod()
                      .AllowAnyHeader());
        });

        // Swagger
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Quartz Scheduler
        builder.Services.AddSingleton<IJobFactory, SingletonJobFactory>();
        builder.Services.AddSingleton<ISchedulerFactory, StdSchedulerFactory>();
        builder.Services.AddSingleton<CallApiJob>();
        builder.Services.AddHostedService<QuartzHostedService>();

        // Run job every minute
        builder.Services.AddSingleton(new JobSchedule(
            jobType: typeof(CallApiJob),
            cronExpression: "0 * * * * ?"
        ));

        // Run job every day at 17:30
        builder.Services.AddSingleton(new JobSchedule(
            jobType: typeof(CallApiJob),
            cronExpression: "0 30 17 * * ?"
        ));

        var app = builder.Build();

        // Middleware Pipeline
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        else
        {
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseCors("AllowAll");

        app.UseAuthentication();
        app.UseAuthorization();

        // Endpoints
        app.MapControllers();
        app.MapHub<ChatHub>("/chathub");

        app.Run();
    }
}
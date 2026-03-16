using API.Models;

namespace API.Services
{
    // Interface định nghĩa các phương thức cho dịch vụ JWT
    public interface IJwtTokenService
    {
        string GenerateToken(AccountEmp accountEmp); // Phương thức tạo JWT token
        string GenerateToken(AccountCus accountCus); // Phương thức tạo JWT token

    }
}

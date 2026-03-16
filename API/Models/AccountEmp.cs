namespace API.Models
{
    public class AccountEmp
    {
        /// <summary>
        /// Mã định danh của tài khoản nhân viên
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Mật khẩu
        /// </summary>
        public string? Password { get; set; }

        /// <summary>
        /// Email của tài khoản
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Khóa ngoại tới nhân viên
        /// </summary>
        public int? EmployeeId { get; set; }

        /// <summary>
        /// Đối tượng nhân viên
        /// </summary>
        public Employee? Employee { get; set; }

        /// <summary>
        /// Khóa ngoại tới vai trò
        /// </summary>
        public int? RoleId { get; set; }

        /// <summary>
        /// Vai trò
        /// </summary>
        public Role? Role { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }
    }
}
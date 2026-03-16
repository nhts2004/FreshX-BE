namespace API.Models
{
    public class Role
    {
        /// <summary>
        /// Mã định danh của vai trò
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Tên của vai trò
        /// </summary>
        public string? RoleName { get; set; }

        /// <summary>
        /// Danh sách tài khoản nhân viên
        /// </summary>
        public ICollection<AccountEmp>? AccountEmp { get; set; }
    }
}
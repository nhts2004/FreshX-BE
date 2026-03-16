namespace API.Models
{
    public class Employee
    {
        /// <summary>
        /// Mã định danh của nhân viên
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Tên của nhân viên
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Ngày sinh của nhân viên
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Giới tính của nhân viên
        /// </summary>
        public string? Gender { get; set; }

        /// <summary>
        /// Địa chỉ của nhân viên
        /// </summary>
        public string? Address { get; set; }

        /// <summary>
        /// Số điện thoại của nhân viên
        /// </summary>
        public string? Phone { get; set; }

        /// <summary>
        /// Email của nhân viên
        /// </summary>
        public string? Email { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public ICollection<AccountEmp>? AccountEmp { get; set; }

        public ICollection<Appointment>? Appointments { get; set; }
    }
}
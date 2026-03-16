namespace API.Models
{
    /// <summary>
    /// Quản lý thông tin các cuộc hẹn giữa khách hàng và nhân viên của phòng khám
    /// </summary>
    public class Appointment
    {
        /// <summary>
        /// Mã định danh của cuộc hẹn
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Ngày và giờ của cuộc hẹn
        /// </summary>
        public DateTime AppointmentDate { get; set; }

        /// <summary>
        /// Mã định danh của khách hàng (bệnh nhân)
        /// </summary>
        public int? CustomerId { get; set; }

        /// <summary>
        /// Tham chiếu đến đối tượng khách hàng
        /// </summary>
        public Customer? Customer { get; set; }

        /// <summary>
        /// Mã định danh của nhân viên (bác sĩ hoặc nhân viên y tế)
        /// </summary>
        public int? EmployeeId { get; set; }

        /// <summary>
        /// Tham chiếu đến đối tượng nhân viên
        /// </summary>
        public Employee? Employee { get; set; }

        /// <summary>
        /// Mô tả chi tiết về cuộc hẹn
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Trạng thái của cuộc hẹn (Scheduled, Completed, Cancelled)
        /// </summary>
        public string? Status { get; set; }
    }
}
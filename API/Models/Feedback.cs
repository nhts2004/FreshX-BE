namespace API.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        public string? Comment { get; set; }

        /// <summary>
        /// Ngày và giờ của feedback
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Trạng thái của feedback (Scheduled, Completed, Cancelled)
        /// </summary>
        public string? Status { get; set; }

        public int Rating { get; set; }

        /// <summary>
        /// Id tài khoản của khách hàng (bệnh nhân)
        /// </summary>
        public int? AccountId { get; set; }

        /// <summary>
        /// Tham chiếu đến đối tượng tài khoản khách hàng  
        /// </summary>
        public AccountCus? AccountCus { get; set; }
    }
}
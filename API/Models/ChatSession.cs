namespace API.Models
{
    /// <summary>
    /// Model lưu trữ thông tin cuộc trò chuyện
    /// </summary>
    public class ChatSession
    {
        /// <summary>
        /// Mã định danh của cuộc trò chuyện
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Mã định danh của khách hàng (nếu có)
        /// </summary>
        public int? CustomerId { get; set; }

        /// <summary>
        /// Tham chiếu đến đối tượng khách hàng
        /// </summary>
        public Customer? Customer { get; set; }

        /// <summary>
        /// Mã định danh của nhân viên (nếu có)
        /// </summary>
        public int? EmployeeId { get; set; }

        /// <summary>
        /// Tham chiếu đến đối tượng nhân viên
        /// </summary>
        public Employee? Employee { get; set; }

        /// <summary>
        /// Thời gian bắt đầu cuộc trò chuyện
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Thời gian kết thúc cuộc trò chuyện (nếu có)
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Danh sách tin nhắn trong cuộc trò chuyện
        /// </summary>
        public ICollection<ChatMessage>? ChatMessages { get; set; }
    }
}
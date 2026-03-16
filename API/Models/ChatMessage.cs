namespace API.Models
{
    /// <summary>
    /// Model lưu trữ thông tin đoạn chat
    /// </summary>
    public class ChatMessage
    {
        /// <summary>
        /// Mã định danh của đoạn chat
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Mã định danh của cuộc trò chuyện
        /// </summary>
        public int? ChatSessionId { get; set; }

        /// <summary>
        /// Tham chiếu đến đối tượng cuộc trò chuyện
        /// </summary>
        public ChatSession? ChatSession { get; set; }

        /// <summary>
        /// Người gửi (Customer, Employee, hoặc Bot)
        /// </summary>
        public string? Sender { get; set; }

        /// <summary>
        /// Nội dung đoạn chat
        /// </summary>
        public string? Message { get; set; }

        /// <summary>
        /// Loại tin nhắn (text, image, etc.)
        /// </summary>
        public string? MessageType { get; set; }

        /// <summary>
        /// Thời gian gửi
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// URL của hình ảnh (nếu có)
        /// </summary>
        public string? ImageUrl { get; set; }
    }
}
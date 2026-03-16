namespace API.Models
{
    public class Insurance
    {
        /// <summary>
        /// Mã định danh của bảo hiểm
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nhà cung cấp bảo hiểm
        /// </summary>
        public string? Provider { get; set; }

        /// <summary>
        /// Số hợp đồng bảo hiểm
        /// </summary>
        public string? PolicyNumber { get; set; }

        /// <summary>
        /// Ngày hết hạn
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Khóa ngoại tới khách hàng
        /// </summary>
        public int? CustomerId { get; set; }

        /// <summary>
        /// Đối tượng khách hàng
        /// </summary>
        public Customer? Customer { get; set; }
    }
}
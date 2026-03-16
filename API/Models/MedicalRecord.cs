namespace API.Models
{
    /// <summary>
    /// Quản lý hồ sơ y tế của khách hàng, bao gồm chi tiết về bệnh án, chẩn đoán, và điều trị
    /// </summary>
    public class MedicalRecord
    {
        /// <summary>
        /// Mã định danh của hồ sơ y tế
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Ngày ghi nhận hồ sơ
        /// </summary>
        public DateTime RecordDate { get; set; }

        /// <summary>
        /// Chi tiết hồ sơ
        /// </summary>
        public string? Details { get; set; }

        /// <summary>
        /// Khóa ngoại tới khách hàng
        /// </summary>
        public int? CustomerId { get; set; }

        /// <summary>
        /// Đối tượng khách hàng
        /// </summary>
        public Customer? Customer { get; set; }

        /// <summary>
        /// Ghi chú liên quan đến hồ sơ y tế
        /// </summary>
        public ICollection<Note>? Notes { get; set; }
    }
}
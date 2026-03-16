namespace API.Models
{
    public class Note
    {
        /// <summary>
        /// Mã định danh của ghi chú
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nội dung của ghi chú
        /// </summary>
        public string? Content { get; set; }

        /// <summary>
        /// Ngày tạo ghi chú
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Khóa ngoại tới hồ sơ y tế
        /// </summary>
        public int? MedicalRecordId { get; set; }

        /// <summary>
        /// Đối tượng hồ sơ y tế
        /// </summary>
        public MedicalRecord? MedicalRecord { get; set; }

        /// <summary>
        /// Khóa ngoại tới chẩn đoán
        /// </summary>
        public int? DiagnosisId { get; set; }

        /// <summary>
        /// Đối tượng chẩn đoán
        /// </summary>
        public Diagnosis? Diagnosis { get; set; }
    }
}
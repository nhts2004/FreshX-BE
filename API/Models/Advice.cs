namespace API.Models
{
    public class Advice
    {
        /// <summary>
        /// Mã định danh lời khuyên
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Mã chẩn đoán liên quan
        /// </summary>
        public int? DiagnosisId { get; set; }

        /// <summary>
        /// Tham chiếu đến đối tượng chẩn đoán
        /// </summary>
        public Diagnosis? Diagnosis { get; set; }

        /// <summary>
        /// Nội dung lời khuyên
        /// </summary>
        public string? Content { get; set; }
    }
}
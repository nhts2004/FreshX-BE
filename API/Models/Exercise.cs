namespace API.Models
{
    public class Exercise
    {
        /// <summary>
        /// Mã định danh của bài tập
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Tên của bài tập
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Mô tả của bài tập
        /// </summary>
        public string? Description { get; set; }

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
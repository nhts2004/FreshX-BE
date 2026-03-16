namespace API.Models
{
    public class Meal
    {
        /// <summary>
        /// Mã định danh của bữa ăn
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Tên của bữa ăn
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Mô tả của bữa ăn
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
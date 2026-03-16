namespace API.Models
{
    public class Symptom
    {
        /// <summary>
        /// Mã định danh của triệu chứng
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Tên của triệu chứng
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Mô tả của triệu chứng
        /// </summary>
        public string? Description { get; set; }

        public ICollection<DiagnosisSymptom> DiagnosisSymptoms { get; set; } = new List<DiagnosisSymptom>();
    }
}
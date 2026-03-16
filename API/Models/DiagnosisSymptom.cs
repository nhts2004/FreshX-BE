namespace API.Models
{
    public class DiagnosisSymptom
    {
        /// <summary>
        /// Khóa ngoại tới chẩn đoán
        /// </summary>
        public int? DiagnosisId { get; set; }

        /// <summary>
        /// Đối tượng chẩn đoán
        /// </summary>
        public Diagnosis? Diagnosis { get; set; }

        /// <summary>
        /// Khóa ngoại tới triệu chứng
        /// </summary>
        public int? SymptomId { get; set; }

        /// <summary>
        /// Đối tượng triệu chứng
        /// </summary>
        public Symptom? Symptom { get; set; }
    }
}
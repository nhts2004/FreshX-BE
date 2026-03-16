namespace API.Models
{
    public class Diagnosis
    {
        /// <summary>
        /// Mã định danh chẩn đoán
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Tên chẩn đoán
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Mô tả chẩn đoán
        /// </summary>
        public string? Description { get; set; }

        public ICollection<DiagnosisSymptom>? DiagnosisSymptoms { get; set; }

        public ICollection<Advice>? Advices { get; set; }

        public ICollection<Exercise>? Exercises { get; set; }

        public ICollection<Meal>? Meals { get; set; }

        public ICollection<Note>? Notes { get; set; }
    }
}
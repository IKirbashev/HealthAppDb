using System.ComponentModel.DataAnnotations;

namespace HealthApp.Models
{
    public class Medication
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;
        [MaxLength(50)]
        public string? Dosage { get; set; }
        [MaxLength(50)]
        public string? Frequency { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}

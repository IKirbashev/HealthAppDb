using System.ComponentModel.DataAnnotations;

namespace HealthApp.Models
{
    public class HealthRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [Required]
        [MaxLength(100)]
        public string Type { get; set; } = null!;
        [MaxLength(500)]
        public string? Symptoms { get; set; }
        [MaxLength(500)]
        public string? Recommendations { get; set; }
    }
}

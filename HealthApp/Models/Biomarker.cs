using System.ComponentModel.DataAnnotations;

namespace HealthApp.Models
{
    public class Biomarker
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; } = null!;
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
        [MaxLength(50)]
        public string? Unit { get; set; }
    }
}

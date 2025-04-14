using System;
using System.ComponentModel.DataAnnotations;

namespace HealthApp.Models
{
    public class Document
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string FileName { get; set; } = null!;
        [Required]
        [MaxLength(500)]
        public string FilePath { get; set; } = null!;
        public DateTime UploadDate { get; set; }
    }
}

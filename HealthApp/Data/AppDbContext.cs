using HealthApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<HealthRecord> HealthRecords { get; set; } = null!;
        public DbSet<Biomarker> Biomarkers { get; set; } = null!;
        public DbSet<Medication> Medications { get; set; } = null!;
        public DbSet<Document> Documents { get; set; } = null!;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Biomarker>()
                .Property(b => b.Value)
                .HasPrecision(10, 2);
        }
    }
}

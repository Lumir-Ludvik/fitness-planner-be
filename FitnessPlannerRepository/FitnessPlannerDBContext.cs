using FitnessPlannerRepository.Entities;
using Microsoft.EntityFrameworkCore;


namespace FitnessPlannerRepository
{
    public class FitnessPlannerDBContext : DbContext
    {
        public FitnessPlannerDBContext(DbContextOptions<FitnessPlannerDBContext> options) : base(options)
        {
        }

        public DbSet<ModuleEntity> Modules { get; set; }
        public DbSet<CalendarEntity> Calendars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CalendarEntity>()
                .HasMany(x => x.Modules)
                .WithOne(x => x.Calendar)
                .HasForeignKey(x => x.CalendarId)
                .HasPrincipalKey(x => x.Id);
        }

    }
}

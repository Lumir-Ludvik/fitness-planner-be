using FitnessPlannerRepository.Entities;
using FitnessPlannerRepository.Entities.@base;
using FitnessPlannerRepository.Entities.WeekDays;
using Microsoft.EntityFrameworkCore;


namespace FitnessPlannerRepository
{
    public class FitnessPlannerDBContext : DbContext
    {
        public FitnessPlannerDBContext(DbContextOptions<FitnessPlannerDBContext> options) : base(options)
        {
        }

        public DbSet<ModuleEntity> Modules { get; set; }
        public DbSet<MondayEntity> Mondays { get; set; }
        public DbSet<TuesdayEntity> Tuesdays { get; set; }
        public DbSet<WednesdayEntity> Wednesdays { get; set; }
        public DbSet<ThursdayEntity> Thursdays { get; set; }
        public DbSet<FridayEntity> Fridays { get; set; }
        public DbSet<SaturdayEntity> Saturdays { get; set; }
        public DbSet<SundayEntity> Sundays { get; set; }
        public DbSet<CalendarEntity> Calendars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ModuleEntity>()
                   .HasOne(x => x.Day)
                   .WithMany(x => x.Modules)
                   .HasForeignKey(x => x.DayId)
                   .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MondayEntity>()
                .HasOne(x => x.Calendar)
                .WithOne(x => x.Monday)
                .HasForeignKey<CalendarEntity>(x => x.MondayId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TuesdayEntity>()
               .HasOne(x => x.Calendar)
               .WithOne(x => x.Tuesday)
               .HasForeignKey<CalendarEntity>(x => x.TuesdayId)
               .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<WednesdayEntity>()
               .HasOne(x => x.Calendar)
               .WithOne(x => x.Wednesday)
               .HasForeignKey<CalendarEntity>(x => x.WednesdayId)
               .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ThursdayEntity>()
               .HasOne(x => x.Calendar)
               .WithOne(x => x.Thursday)
               .HasForeignKey<CalendarEntity>(x => x.ThursdayId)
               .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<FridayEntity>()
               .HasOne(x => x.Calendar)
               .WithOne(x => x.Friday)
               .HasForeignKey<CalendarEntity>(x => x.FridayId)
               .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<SaturdayEntity>()
               .HasOne(x => x.Calendar)
               .WithOne(x => x.Saturday)
               .HasForeignKey<CalendarEntity>(x => x.SaturdayId)
               .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<SundayEntity>()
               .HasOne(x => x.Calendar)
               .WithOne(x => x.Sunday)
               .HasForeignKey<CalendarEntity>(x => x.SundayId)
               .OnDelete(DeleteBehavior.NoAction);
        }

    }
}

namespace FitnessPlannerRepository.Entities.@base
{
    public class DayBaseEntity : EntityBase
    {
        public Guid CalendarId { get; set; }
        public CalendarEntity Calendar { get; set; }
        public ICollection<ModuleEntity>? Modules { get; set; }
    }
}

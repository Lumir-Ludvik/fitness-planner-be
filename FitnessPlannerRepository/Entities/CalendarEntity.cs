namespace FitnessPlannerRepository.Entities
{
    public class CalendarEntity : EntityBase
    {
        public ICollection<ModuleEntity>? Modules { get; set; }
    }
}

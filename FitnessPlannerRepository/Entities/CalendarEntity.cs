using FitnessPlannerRepository.Entities.@base;
using FitnessPlannerRepository.Entities.WeekDays;

namespace FitnessPlannerRepository.Entities
{
    public class CalendarEntity : EntityBase
    {
        public Guid MondayId { get; set; }
        public MondayEntity Monday { get; set; }
        public Guid TuesdayId { get; set; }
        public TuesdayEntity Tuesday { get; set; }
        public Guid WednesdayId { get; set; }
        public WednesdayEntity Wednesday { get; set; }
        public Guid ThursdayId { get; set; }
        public ThursdayEntity Thursday { get; set; }
        public Guid FridayId { get; set; }
        public FridayEntity Friday { get; set; }
        public Guid SaturdayId { get; set; }
        public SaturdayEntity Saturday { get; set; }
        public Guid SundayId { get; set; }
        public SundayEntity Sunday { get; set; }
    }
}

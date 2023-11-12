using FitnessPlannerRepository.Entities;
using FitnessPlannerRepository.Repository.Interfaces;

namespace FitnessPlannerRepository.Repository
{
    public class CalendarRepository: BaseRepository<CalendarEntity>, ICalendarRepository
    {
        public CalendarRepository(FitnessPlannerDBContext context) : base(context)
        {
            
        }
    }
}

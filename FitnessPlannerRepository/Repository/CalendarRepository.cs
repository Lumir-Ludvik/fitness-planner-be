using FitnessPlannerRepository.Entities;

namespace FitnessPlannerRepository.Repository
{
    public class CalendarRepository: BaseRepository<CalendarEntity, FitnessPlannerDBContext>
    {
        public CalendarRepository(FitnessPlannerDBContext context) : base(context)
        {
            
        }
    }
}

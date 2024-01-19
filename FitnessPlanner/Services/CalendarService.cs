using FitnessPlanner.Services.interfaces;
using FitnessPlannerRepository.Entities;
using FitnessPlannerRepository.Repository;

namespace FitnessPlanner.Services
{
    public class CalendarService : BaseControllerService<CalendarEntity, CalendarRepository>
    {
        public CalendarService(CalendarRepository repository) : base(repository)
        {
        }
    }
}

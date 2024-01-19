using FitnessPlannerRepository.Entities;
using FitnessPlannerRepository.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FitnessPlanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarController : BaseController<CalendarEntity, ICalendarRepository>
    {
        public CalendarController(ICalendarRepository calendarRepository) : base(calendarRepository)
        {

        }
    }
}

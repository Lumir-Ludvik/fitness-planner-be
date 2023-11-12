using FitnessPlannerRepository.Entities;
using FitnessPlannerRepository.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FitnessPlanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarController : BaseController<CalendarEntity, CalendarRepository>
    {
        public CalendarController(CalendarRepository calendarRepository) : base(calendarRepository) 
        {
            
        }
    }
}

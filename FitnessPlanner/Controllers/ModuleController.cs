using FitnessPlannerRepository.Entities;
using FitnessPlannerRepository.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FitnessPlanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModuleController : BaseController<ModuleEntity, IModuleRepository>
    {
        public ModuleController(IModuleRepository moduleRepository) : base(moduleRepository)
        {

        }
    }
}

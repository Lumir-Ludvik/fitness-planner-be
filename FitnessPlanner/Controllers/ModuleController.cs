using FitnessPlannerRepository.Entities;
using FitnessPlannerRepository.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FitnessPlanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModuleController : BaseController<ModuleEntity, ModuleRepository>
    {
        public ModuleController(ModuleRepository moduleRepository): base(moduleRepository) { }
    }
}

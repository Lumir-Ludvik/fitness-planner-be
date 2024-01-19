using FitnessPlannerRepository.Entities;
using FitnessPlannerRepository.Repository;

namespace FitnessPlanner.Services
{
    public class ModuleService : BaseControllerService<ModuleEntity, ModuleRepository>
    {
        public ModuleService(ModuleRepository repository) : base(repository)
        {
        }
    }
}

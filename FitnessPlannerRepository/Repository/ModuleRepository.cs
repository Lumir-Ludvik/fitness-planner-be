using FitnessPlannerRepository.Entities;
using FitnessPlannerRepository.Repository.Interfaces;

namespace FitnessPlannerRepository.Repository
{
    public class ModuleRepository : BaseRepository<ModuleEntity>, IModuleRepository
    {
        public ModuleRepository(FitnessPlannerDBContext context) : base(context)
        {
        }
    }
}

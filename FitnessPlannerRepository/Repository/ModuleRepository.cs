using FitnessPlannerRepository.Entities;

namespace FitnessPlannerRepository.Repository
{
    public class ModuleRepository : BaseRepository<ModuleEntity, FitnessPlannerDBContext>
    {
        public ModuleRepository(FitnessPlannerDBContext context) : base(context)
        {
        }
    }
}

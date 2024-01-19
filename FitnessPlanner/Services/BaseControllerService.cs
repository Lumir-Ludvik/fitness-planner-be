using FitnessPlanner.Services.interfaces;
using FitnessPlannerRepository.Entities.Interfaces;
using FitnessPlannerRepository.Repository.Interfaces;

namespace FitnessPlanner.Services
{
    public class BaseControllerService<TEntity, TRepository> : IBaseControllerService<TEntity, TRepository>
          where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public BaseControllerService(TRepository repository)
        {
            this.repository = repository;
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            return await repository.Add(entity);
        }

        public async Task<TEntity> DeleteAsync(Guid id)
        {
            return await repository.Delete(id);
        }

        public async Task<ICollection<TEntity>> GetAllAsync()
        {
            return await repository.GetAll();
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await repository.Get(id);
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            return await repository.Update(entity);
        }
    }
}

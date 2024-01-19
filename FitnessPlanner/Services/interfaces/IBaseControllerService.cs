using FitnessPlannerRepository.Entities.@base;
using FitnessPlannerRepository.Entities.Interfaces;
using FitnessPlannerRepository.Repository.Interfaces;

namespace FitnessPlanner.Services.interfaces
{
    public interface IBaseControllerService<TEntity, TRepository> 
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> DeleteAsync(Guid id);
        Task<ICollection<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(Guid id);

    }
}

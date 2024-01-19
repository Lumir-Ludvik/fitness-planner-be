

using FitnessPlannerRepository.Entities.Interfaces;

namespace FitnessPlannerRepository.Repository.Interfaces
{
    public interface IBaseRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity
    {
        Task<TEntity> Add(TEntity entity);

        Task<TEntity> Delete(Guid id);

        Task<TEntity> Get(Guid id);

        Task<ICollection<TEntity>> GetAll();

        Task<TEntity> Update(TEntity entity);
    }
}

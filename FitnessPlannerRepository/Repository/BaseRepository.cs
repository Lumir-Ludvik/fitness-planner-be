using FitnessPlannerRepository.Entities.Interfaces;
using FitnessPlannerRepository.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FitnessPlannerRepository.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class, IEntity
    {
        private readonly FitnessPlannerDBContext context;

        public BaseRepository(FitnessPlannerDBContext context)
        {
            this.context = context;
            this.context.Set<TEntity>();
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            context.Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Delete(Guid id)
        {
            var entity = await context.FindAsync<TEntity>(id);
            if (entity == null)
            {
                return entity;
            }

            context.Remove(entity);
            await context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> Get(Guid id)
        {
            return await context.FindAsync<TEntity>(id);
        }

        public async Task<ICollection<TEntity>> GetAll()
        {
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return entity;
        }
    }
}

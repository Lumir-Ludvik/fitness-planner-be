using FitnessPlannerRepository.Entities.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FitnessPlanner.Controllers.interfaces
{
    public interface IBaseController<TEntity> where TEntity : IEntity
    {
        [HttpGet]
        Task<ActionResult<ICollection<TEntity>>> Get(int id);

        [HttpGet("{id}")]
        Task<ActionResult<ICollection<TEntity>>> Get(Guid id);

        [HttpPost]
        Task<ActionResult<TEntity>> Post(TEntity entity);

        [HttpPut]
        Task<ActionResult<TEntity>> Put(TEntity entity);

        [HttpDelete("{id}")]
        Task<ActionResult<bool>> Delete(Guid id);
    }
}

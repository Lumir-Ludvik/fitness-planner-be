using FitnessPlanner.Controllers.interfaces;
using FitnessPlannerRepository.Entities.Interfaces;
using FitnessPlannerRepository.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FitnessPlanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity, TRepository> : ControllerBase, IBaseController<TEntity>
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public BaseController(TRepository repository)
        {
            this.repository = repository;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(Guid id)
        {
            //TODO: fix this cardinal sin
            await repository.Delete(id);

            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<TEntity>>> Get()
        {
            return Ok(await repository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ICollection<TEntity>>> Get(Guid id)
        {
            return Ok(await repository.Get(id));
        }

        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity entity)
        {
            await repository.Add(entity);

            return Ok(entity);
        }

        [HttpPut]
        public async Task<ActionResult<TEntity>> Put(TEntity entity)
        {
            await repository.Update(entity);

            return Ok(entity);
        }
    }
}

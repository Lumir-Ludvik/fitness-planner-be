using FitnessPlanner.Controllers.interfaces;
using FitnessPlanner.Services.interfaces;
using FitnessPlannerRepository.Entities.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FitnessPlanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase, IBaseController<TEntity>
        where TEntity : class, IEntity
    {
        private readonly IBaseControllerService<TEntity> baseControllerService;

        public BaseController(IBaseControllerService<TEntity> baseControllerService)
        {
            this.baseControllerService = baseControllerService;
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(Guid id)
        {
            await baseControllerService.DeleteAsync(id);

            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<TEntity>>> Get()
        {
            return Ok(await baseControllerService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ICollection<TEntity>>> Get(Guid id)
        {
            return Ok(await baseControllerService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity entity)
        {
            await baseControllerService.CreateAsync(entity);

            return Ok(entity);
        }

        [HttpPut]
        public async Task<ActionResult<TEntity>> Put(TEntity entity)
        {
            await baseControllerService.UpdateAsync(entity);

            return Ok(entity);
        }
    }
}

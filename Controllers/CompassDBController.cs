using System.Collections.Generic;
using System.Threading.Tasks;
using CompassSurvey.Data;
using Microsoft.AspNetCore.Mvc;

namespace CompassSurvey.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public abstract class CompassDBController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public CompassDBController(TRepository repository)
        {
            this.repository = repository;
        }


        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var survey = await repository.Get(id);
            if (survey == null)
            {
                return NotFound();
            }
            return survey;
        }

        // PUT: api/[controller]/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(int id, TEntity survey)
        //{
        //    if (id != survey.Id)
        //    {
        //        return BadRequest();
        //    }
        //    await repository.Update(survey);
        //    return NoContent();
        //}

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity survey)
        {
            await repository.Add(survey);
            return CreatedAtAction("Get", new { id = survey.Id }, survey);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var survey = await repository.Delete(id);
            if (survey == null)
            {
                return NotFound();
            }
            return survey;
        }

    }
}

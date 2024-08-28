using HouseManagment.Activities;
using HouseManagment.Activities.Services;
using HouseManagment.Contracts.Activities;
using HouseManagment.Infrastucture;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HouseManagment.Controllers
{
    [Route("api/activities")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityService activityService;
        private readonly IRepository<Activity> repository;

        public ActivityController(IActivityService activityService, IRepository<Activity> repository)
        {
            this.activityService = activityService;
            this.repository = repository;
        }

        // GET: api/<ActivityController>
        [HttpGet]
        public async Task<IReadOnlyCollection<Activity>> Get()
        {
            return await repository.GetAll();
        }

        // GET api/<ActivityController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> Get(Guid id)
        {
            return Ok(await repository.Get(id));
        }

        // POST api/<ActivityController>
        [HttpPost]
        public async Task<ActionResult<Guid>> Post([FromBody] CreateActivity activity)
        {
            return Ok(await activityService.AddActivity(activity));
        }

        // PUT api/<ActivityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ActivityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

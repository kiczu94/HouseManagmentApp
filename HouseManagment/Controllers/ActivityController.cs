using HouseMagment.Application.Activities;
using HouseManagment.Contracts.Activities.Commands;
using HouseManagment.Contracts.Activities.Entities;
using HouseManagment.Contracts.Activities.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HouseManagment.Controllers
{
    [Route("api/activities")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IMediator mediator;

        public ActivityController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET: api/<ActivityController>
        [HttpGet]
        public async Task<IReadOnlyCollection<ActivityItem>> Get()
        {
            return await mediator.Send(new GetAllActivities());
        }

        // GET api/<ActivityController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> Get(Guid id)
        {
            return Ok(await mediator.Send(new GetActivityDetails(id)));
        }

        // POST api/<ActivityController>
        [HttpPost]
        public async Task<ActionResult<Guid>> Post([FromBody] CreateActivity activity)
        {
            return Ok(await mediator.Send(activity));
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

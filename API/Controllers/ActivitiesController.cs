
namespace API.Controllers
{

    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Persistence;
    using Domain;
    using SQLitePCL;
    using MediatR;
    using Application.Activities;
    public class ActivitiesController : BaseApiController
    {
        private readonly IMediator _mediator;

        public Activities Controller(IMediator mediator)
        {
            _mediator = mediator;

        }
        

        [HttpGet] //api/activities
        public async Task<ActionResult<List<Domain.Activity>>> GetActivities()
        {
            return await _mediator.Send(new List.Query());
        }
        
        [HttpGet("{id}")]

        public async Task<ActionResult<Domain.Activity>> GetActivities(Guid id)
        {
            return Ok();
        }
    }
}
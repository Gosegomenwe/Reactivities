using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Domain;
using SQLitePCL;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;
        
        public ActivitiesController(DataContext context)
        {
           _context = context;
            
        }

        [HttpGet] //api/activities
        public async Task<ActionResult<List<Domain.Activity>>> GetActivities()
        {
            return await _context.Activities.ToListAsync();
        }
        
        [HttpGet("{id}")]

        public async Task<ActionResult<Domain.Activity>> GetActivities(Guid id)
        {
            return await _context.Activities.FindAsync(id);
        }
    }
}
using HealthApp.Data;
using HealthApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace HealthApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthRecordsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HealthRecordsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/healthrecords
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var records = await _context.HealthRecords.ToListAsync();
            return Ok(records);
        }

        // POST: api/healthrecords
        [HttpPost]
        public async Task<IActionResult> Create(HealthRecord record)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.HealthRecords.Add(record);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAll), new {id = record.Id}, record);
        }
    }
}

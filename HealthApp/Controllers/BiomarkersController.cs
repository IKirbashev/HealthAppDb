using HealthApp.Data;
using HealthApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace HealthApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BiomarkersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BiomarkersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/biomarkers
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var biomarkers = await _context.Biomarkers.ToListAsync();
            return Ok(biomarkers);
        }

        // POST: api/biomarkers
        [HttpPost]
        public async Task<IActionResult> Create(Biomarker biomarker)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Biomarkers.Add(biomarker);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAll), new { id = biomarker.Id }, biomarker);
        }
    }
}

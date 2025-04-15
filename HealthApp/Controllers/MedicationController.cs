using HealthApp.Data;
using HealthApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace HealthApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicationController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MedicationController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/controllers
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var medications = await _context.Medications.ToListAsync();
            return Ok(medications);
        }

        // POST: api/controllers
        [HttpPost]
        public async Task<IActionResult> Create(Medication medication)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Medications.Add(medication);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAll), new { id = medication.Id }, medication);
        }
    }
}

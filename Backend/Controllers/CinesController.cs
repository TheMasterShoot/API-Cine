using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend;
using Backend.Models;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinesController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public CinesController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Cines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cine>>> GetCine()
        {
            return await _context.Cine.ToListAsync();
        }

        // GET: api/Cines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cine>> GetCine(int id)
        {
            var cine = await _context.Cine.FindAsync(id);

            if (cine == null)
            {
                return NotFound();
            }

            return cine;
        }

        // PUT: api/Cines/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCine(int id, Cine cine)
        {
            if (id != cine.id)
            {
                return BadRequest();
            }

            _context.Entry(cine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CineExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Cines
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Cine>> PostCine(Cine cine)
        {
            _context.Cine.Add(cine);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCine", new { id = cine.id }, cine);
        }

        // DELETE: api/Cines/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cine>> DeleteCine(int id)
        {
            var cine = await _context.Cine.FindAsync(id);
            if (cine == null)
            {
                return NotFound();
            }

            _context.Cine.Remove(cine);
            await _context.SaveChangesAsync();

            return cine;
        }

        private bool CineExists(int id)
        {
            return _context.Cine.Any(e => e.id == id);
        }
    }
}

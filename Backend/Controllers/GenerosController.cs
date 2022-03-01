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
    public class GenerosController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public GenerosController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Generos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Generos>>> GetGeneros()
        {
            return await _context.Generos.ToListAsync();
        }

        // GET: api/Generos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Generos>> GetGeneros(int id)
        {
            var generos = await _context.Generos.FindAsync(id);

            if (generos == null)
            {
                return NotFound();
            }

            return generos;
        }

        // PUT: api/Generos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGeneros(int id, Generos generos)
        {
            if (id != generos.id)
            {
                return BadRequest();
            }

            _context.Entry(generos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GenerosExists(id))
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

        // POST: api/Generos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Generos>> PostGeneros(Generos generos)
        {
            _context.Generos.Add(generos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGeneros", new { id = generos.id }, generos);
        }

        // DELETE: api/Generos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Generos>> DeleteGeneros(int id)
        {
            var generos = await _context.Generos.FindAsync(id);
            if (generos == null)
            {
                return NotFound();
            }

            _context.Generos.Remove(generos);
            await _context.SaveChangesAsync();

            return generos;
        }

        private bool GenerosExists(int id)
        {
            return _context.Generos.Any(e => e.id == id);
        }
    }
}

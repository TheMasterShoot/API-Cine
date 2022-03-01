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
    public class ModalidadController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public ModalidadController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Modalidad
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Modalidad>>> GetModalidad()
        {
            return await _context.Modalidad.ToListAsync();
        }

        // GET: api/Modalidad/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Modalidad>> GetModalidad(int id)
        {
            var modalidad = await _context.Modalidad.FindAsync(id);

            if (modalidad == null)
            {
                return NotFound();
            }

            return modalidad;
        }

        // PUT: api/Modalidad/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModalidad(int id, Modalidad modalidad)
        {
            if (id != modalidad.id)
            {
                return BadRequest();
            }

            _context.Entry(modalidad).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModalidadExists(id))
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

        // POST: api/Modalidad
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Modalidad>> PostModalidad(Modalidad modalidad)
        {
            _context.Modalidad.Add(modalidad);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetModalidad", new { id = modalidad.id }, modalidad);
        }

        // DELETE: api/Modalidad/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Modalidad>> DeleteModalidad(int id)
        {
            var modalidad = await _context.Modalidad.FindAsync(id);
            if (modalidad == null)
            {
                return NotFound();
            }

            _context.Modalidad.Remove(modalidad);
            await _context.SaveChangesAsync();

            return modalidad;
        }

        private bool ModalidadExists(int id)
        {
            return _context.Modalidad.Any(e => e.id == id);
        }
    }
}

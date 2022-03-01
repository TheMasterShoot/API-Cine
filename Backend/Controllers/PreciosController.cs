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
    public class PreciosController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public PreciosController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Precios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Precio>>> GetPrecio()
        {
            return await _context.Precio.ToListAsync();
        }

        // GET: api/Precios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Precio>> GetPrecio(int id)
        {
            var precio = await _context.Precio.FindAsync(id);

            if (precio == null)
            {
                return NotFound();
            }

            return precio;
        }

        // PUT: api/Precios/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrecio(int id, Precio precio)
        {
            if (id != precio.id)
            {
                return BadRequest();
            }

            _context.Entry(precio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrecioExists(id))
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

        // POST: api/Precios
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Precio>> PostPrecio(Precio precio)
        {
            _context.Precio.Add(precio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrecio", new { id = precio.id }, precio);
        }

        // DELETE: api/Precios/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Precio>> DeletePrecio(int id)
        {
            var precio = await _context.Precio.FindAsync(id);
            if (precio == null)
            {
                return NotFound();
            }

            _context.Precio.Remove(precio);
            await _context.SaveChangesAsync();

            return precio;
        }

        private bool PrecioExists(int id)
        {
            return _context.Precio.Any(e => e.id == id);
        }
    }
}

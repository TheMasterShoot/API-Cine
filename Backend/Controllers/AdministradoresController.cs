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
    public class AdministradoresController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public AdministradoresController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Administradores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Administradores>>> GetAdministradores()
        {
            return await _context.Administradores.ToListAsync();
        }

        // GET: api/Administradores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Administradores>> GetAdministradores(int id)
        {
            var administradores = await _context.Administradores.FindAsync(id);

            if (administradores == null)
            {
                return NotFound();
            }

            return administradores;
        }

        // PUT: api/Administradores/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdministradores(int id, Administradores administradores)
        {
            if (id != administradores.id)
            {
                return BadRequest();
            }

            _context.Entry(administradores).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdministradoresExists(id))
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

        // POST: api/Administradores
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Administradores>> PostAdministradores(Administradores administradores)
        {
            _context.Administradores.Add(administradores);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdministradores", new { id = administradores.id }, administradores);
        }

        // DELETE: api/Administradores/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Administradores>> DeleteAdministradores(int id)
        {
            var administradores = await _context.Administradores.FindAsync(id);
            if (administradores == null)
            {
                return NotFound();
            }

            _context.Administradores.Remove(administradores);
            await _context.SaveChangesAsync();

            return administradores;
        }

        private bool AdministradoresExists(int id)
        {
            return _context.Administradores.Any(e => e.id == id);
        }
    }
}

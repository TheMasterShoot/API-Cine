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
    public class PeliculasController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public PeliculasController(AplicationDbContext context)
        {
            _context = context;
        }

        /* // GET: api/Peliculas
         [HttpGet]
         public async Task<ActionResult<IEnumerable<Peliculas>>> GetPeliculas()
         {
             return await _context.Peliculas.ToListAsync();
         }*/

       

        // GET: api/Peliculas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Peliculas>> GetPeliculas(int id)
        {
            var peliculas = await _context.Peliculas.FindAsync(id);

            if (peliculas == null)
            {
                return NotFound();
            }

            return peliculas;
        }

        // PUT: api/Peliculas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPeliculas(int id, Peliculas peliculas)
        {
            if (id != peliculas.Id)
            {
                return BadRequest();
            }

            _context.Entry(peliculas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeliculasExists(id))
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

        // GET: api/Peliculas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Peliculas>>> GetPeliculas([FromQuery] PeliculaFilter peliculaFilter)
        {
            
            List<Peliculas> peliculas = await _context.Peliculas.ToListAsync();

            if (peliculaFilter.estado != 0)
            {
                peliculas = peliculas.Where(x => x.Estado == peliculaFilter.estado).ToList();
            }
            if (peliculaFilter.proxima != 0)
            {
                peliculas = (from p in peliculas                          
                            where p.FechaEstreno > DateTime.Now
                            orderby p.FechaEstreno ascending
                            select p).ToList();
            }
            if (peliculaFilter.proximamente != 0)
            {
                peliculas = (from p in peliculas
                             where p.FechaEstreno > DateTime.Now
                             orderby p.FechaEstreno ascending
                             select p).Take(10).ToList();
            }
            if (peliculaFilter.estreno != 0)
            {
                peliculas = peliculas.Where(x => x.FechaEstreno == DateTime.Now && x.FechaEstreno <= DateTime.Now.AddDays(1)).ToList();
            }
            if (peliculaFilter.cartelera != 0)
            {
                peliculas = peliculas.Where(x => x.FechaEstreno <= DateTime.Now).ToList();
            }
            if (peliculaFilter.taquillera != 0)
            {                
                peliculas = (from p in peliculas 
                             orderby p.Ventas descending 
                             select p).Take(6).ToList();
            }
            if (peliculaFilter.favoritas != 0)
            {
                peliculas = (from p in peliculas
                             orderby p.Ventas descending
                             select p).Take(10).ToList();
            }

            return  peliculas;
          
        }

        // POST: api/Peliculas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Peliculas>> PostPeliculas(Peliculas peliculas)
        {
            _context.Peliculas.Add(peliculas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPeliculas", new { id = peliculas.Id }, peliculas);
        }

        // DELETE: api/Peliculas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Peliculas>> DeletePeliculas(int id)
        {
            var peliculas = await _context.Peliculas.FindAsync(id);
            if (peliculas == null)
            {
                return NotFound();
            }

            _context.Peliculas.Remove(peliculas);
            await _context.SaveChangesAsync();

            return peliculas;
        }

        private bool PeliculasExists(int id)
        {
            return _context.Peliculas.Any(e => e.Id == id);
        }
    }
}

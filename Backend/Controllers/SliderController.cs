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
    public class SliderController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public SliderController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Slider
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Slider>>> GetSlider()
        {
            return await _context.Slider.ToListAsync();
        }

        // GET: api/Slider/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Slider>> GetSlider(int id)
        {
            var slider = await _context.Slider.FindAsync(id);

            if (slider == null)
            {
                return NotFound();
            }

            return slider;
        }

        // PUT: api/Slider/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSlider(int id, Slider slider)
        {
            if (id != slider.id)
            {
                return BadRequest();
            }

            _context.Entry(slider).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SliderExists(id))
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

        // POST: api/Slider
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Slider>> PostSlider(Slider slider)
        {
            _context.Slider.Add(slider);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSlider", new { id = slider.id }, slider);
        }

        // DELETE: api/Slider/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Slider>> DeleteSlider(int id)
        {
            var slider = await _context.Slider.FindAsync(id);
            if (slider == null)
            {
                return NotFound();
            }

            _context.Slider.Remove(slider);
            await _context.SaveChangesAsync();

            return slider;
        }

        private bool SliderExists(int id)
        {
            return _context.Slider.Any(e => e.id == id);
        }
    }
}

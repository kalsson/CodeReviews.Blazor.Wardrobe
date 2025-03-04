using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wardrobe.API.Data;
using Wardrobe.API.Models;

namespace Wardrobe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WardrobeController : ControllerBase
    {
        private readonly WardrobeDbContext _context;

        public WardrobeController(WardrobeDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<WardrobeItem>>> GetAll()
        {
            return await _context.WardrobeItems.ToListAsync();
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<WardrobeItem>> Get(int id)
        {
            var item = await _context.WardrobeItems.FindAsync(id);
            if (item == null) return NotFound();
            return item;
        }

        [HttpPost]
        public async Task<ActionResult> Post(WardrobeItem item)
        {
            _context.WardrobeItems.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, WardrobeItem item)
        {
            if (id != item.Id) return BadRequest();

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var item = await _context.WardrobeItems.FindAsync(id);
            if (item == null) return NotFound();

            _context.WardrobeItems.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}

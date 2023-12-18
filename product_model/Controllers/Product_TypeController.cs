using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using product_model.Data;
using product_model.Models;

namespace product_model.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Product_TypeController : ControllerBase
    {
        private readonly appDb _context;

        public Product_TypeController(appDb context)
        {
            _context = context;
        }

        // GET: api/Product_Type
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product_Type>>> Getproduct_types()
        {
            return await _context.product_types.ToListAsync();
        }

        // GET: api/Product_Type/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product_Type>> GetProduct_Type(Guid id)
        {
            var product_Type = await _context.product_types.FindAsync(id);

            if (product_Type == null)
            {
                return NotFound();
            }

            return product_Type;
        }

        // PUT: api/Product_Type/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct_Type(Guid id, Product_Type product_Type)
        {
            if (id != product_Type.Id)
            {
                return BadRequest();
            }

            _context.Entry(product_Type).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Product_TypeExists(id))
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

        // POST: api/Product_Type
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product_Type>> PostProduct_Type(Product_Type product_Type)
        {
            product_Type.Id = Guid.NewGuid();
            _context.product_types.Add(product_Type);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct_Type", new { id = product_Type.Id }, product_Type);
        }

        // DELETE: api/Product_Type/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct_Type(Guid id)
        {
            var product_Type = await _context.product_types.FindAsync(id);
            if (product_Type == null)
            {
                return NotFound();
            }

            _context.product_types.Remove(product_Type);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Product_TypeExists(Guid id)
        {
            return _context.product_types.Any(e => e.Id == id);
        }
    }
}

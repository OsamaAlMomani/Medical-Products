using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using basicModel.Data;
using basicModel.Models;

namespace basicModel.Controllers
{
    public class Product_TypeController : Controller
    {
        private readonly appDb _context;

        public Product_TypeController(appDb context)
        {
            _context = context;
        }

        // GET: Product_Type
        public async Task<IActionResult> Index()
        {
            return View(await _context.product_types.ToListAsync());
        }

        // GET: Product_Type/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product_Type = await _context.product_types
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product_Type == null)
            {
                return NotFound();
            }

            return View(product_Type);
        }

        // GET: Product_Type/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Product_Type/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,number,Name")] Product_Type product_Type)
        {
            if (ModelState.IsValid)
            {
                product_Type.Id = Guid.NewGuid();
                _context.Add(product_Type);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product_Type);
        }

        // GET: Product_Type/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product_Type = await _context.product_types.FindAsync(id);
            if (product_Type == null)
            {
                return NotFound();
            }
            return View(product_Type);
        }

        // POST: Product_Type/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,number,Name")] Product_Type product_Type)
        {
            if (id != product_Type.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product_Type);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Product_TypeExists(product_Type.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product_Type);
        }

        // GET: Product_Type/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product_Type = await _context.product_types
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product_Type == null)
            {
                return NotFound();
            }

            return View(product_Type);
        }

        // POST: Product_Type/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var product_Type = await _context.product_types.FindAsync(id);
            if (product_Type != null)
            {
                _context.product_types.Remove(product_Type);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Product_TypeExists(Guid id)
        {
            return _context.product_types.Any(e => e.Id == id);
        }
    }
}

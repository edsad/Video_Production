using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Video_Production.Models;

namespace Video_Production.Controllers
{
    public class ProductionTypesController : Controller
    {
        private readonly Video_ProductionContext _context;

        public ProductionTypesController(Video_ProductionContext context)
        {
            _context = context;    
        }

        // GET: ProductionTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProductionType.ToListAsync());
        }

        // GET: ProductionTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productionType = await _context.ProductionType
                .SingleOrDefaultAsync(m => m.Id == id);
            if (productionType == null)
            {
                return NotFound();
            }

            return View(productionType);
        }

        // GET: ProductionTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductionTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductionName,Budget")] ProductionType productionType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productionType);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(productionType);
        }

        // GET: ProductionTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productionType = await _context.ProductionType.SingleOrDefaultAsync(m => m.Id == id);
            if (productionType == null)
            {
                return NotFound();
            }
            return View(productionType);
        }

        // POST: ProductionTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductionName,Budget")] ProductionType productionType)
        {
            if (id != productionType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productionType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductionTypeExists(productionType.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(productionType);
        }

        // GET: ProductionTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productionType = await _context.ProductionType
                .SingleOrDefaultAsync(m => m.Id == id);
            if (productionType == null)
            {
                return NotFound();
            }

            return View(productionType);
        }

        // POST: ProductionTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productionType = await _context.ProductionType.SingleOrDefaultAsync(m => m.Id == id);
            _context.ProductionType.Remove(productionType);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ProductionTypeExists(int id)
        {
            return _context.ProductionType.Any(e => e.Id == id);
        }
    }
}

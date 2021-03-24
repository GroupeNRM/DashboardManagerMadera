using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DashboardManagerMadera.Data;
using DashboardManagerMadera.Models;

namespace DashboardManagerMadera.Controllers
{
    public class CommercialController : Controller
    {
        private readonly DashboardManagerMaderaContext _context;

        public CommercialController(DashboardManagerMaderaContext context)
        {
            _context = context;
        }

        // GET: Commercial
        public async Task<IActionResult> Index()
        {
            return View(await _context.Commercial.ToListAsync());
        }

        // GET: Commercial/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commercial = await _context.Commercial
                .FirstOrDefaultAsync(m => m.ID == id);
            if (commercial == null)
            {
                return NotFound();
            }

            return View(commercial);
        }

        // GET: Commercial/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Commercial/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,Email,Phone,Country,CreatedAt")] Commercial commercial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(commercial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(commercial);
        }

        // GET: Commercial/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commercial = await _context.Commercial.FindAsync(id);
            if (commercial == null)
            {
                return NotFound();
            }
            return View(commercial);
        }

        // POST: Commercial/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,LastName,Email,Phone,Country,CreatedAt")] Commercial commercial)
        {
            if (id != commercial.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(commercial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommercialExists(commercial.ID))
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
            return View(commercial);
        }

        // GET: Commercial/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commercial = await _context.Commercial
                .FirstOrDefaultAsync(m => m.ID == id);
            if (commercial == null)
            {
                return NotFound();
            }

            return View(commercial);
        }

        // POST: Commercial/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var commercial = await _context.Commercial.FindAsync(id);
            _context.Commercial.Remove(commercial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommercialExists(int id)
        {
            return _context.Commercial.Any(e => e.ID == id);
        }
    }
}

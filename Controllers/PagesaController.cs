using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Libraryms.Data;
using Libraryms.Models;

namespace Libraryms.Controllers
{
    public class PagesaController : Controller
    {
        private readonly LibrarymsContext _context;

        public PagesaController(LibrarymsContext context)
        {
            _context = context;
        }

        // GET: Pagesas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pagesa.ToListAsync());
        }

        // GET: Pagesas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pagesa = await _context.Pagesa
                .FirstOrDefaultAsync(m => m.id == id);
            if (pagesa == null)
            {
                return NotFound();
            }

            return View(pagesa);
        }

        // GET: Pagesas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pagesas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,shuma,Klienti_id,Active,created_at")] Pagesa pagesa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pagesa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pagesa);
        }

        // GET: Pagesas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pagesa = await _context.Pagesa.FindAsync(id);
            if (pagesa == null)
            {
                return NotFound();
            }
            return View(pagesa);
        }

        // POST: Pagesas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,shuma,Klienti_id,Active,created_at")] Pagesa pagesa)
        {
            if (id != pagesa.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pagesa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PagesaExists(pagesa.id))
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
            return View(pagesa);
        }

        // GET: Pagesas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pagesa = await _context.Pagesa
                .FirstOrDefaultAsync(m => m.id == id);
            if (pagesa == null)
            {
                return NotFound();
            }

            return View(pagesa);
        }

        // POST: Pagesas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pagesa = await _context.Pagesa.FindAsync(id);
            _context.Pagesa.Remove(pagesa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PagesaExists(int id)
        {
            return _context.Pagesa.Any(e => e.id == id);
        }
    }
}

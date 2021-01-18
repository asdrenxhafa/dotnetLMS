using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Libraryms.Models;
using Libraryms.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Libraryms.Controllers
{
    public class RezervimiController : Controller
    {
        private readonly LibrarymsContext _context;

        public RezervimiController(LibrarymsContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> IndexAsync()
        {
            return View(await _context.Rezervimi.ToListAsync());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rezervimi = await _context.Rezervimi
                .FirstOrDefaultAsync(m => m.id == id);

            if (rezervimi == null)
            {
                return NotFound();
            }

            return View(rezervimi);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var r = await _context.Rezervimi.FindAsync(id);
            if (r == null)
            {
                return NotFound();
            }
            return View(r);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Klienti_id,Libra_id,Aktiv,created_at,deleted_at")] Rezervimi r)
        {
            if (id != r.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(r);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RezervimiExists(r.id))
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
            return View(r);
        }
        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(
            [Bind("Klienti_id,Libra_id,Aktiv")] Rezervimi r)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(r);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }
            return View(r);

        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var r = await _context.Rezervimi
                .FirstOrDefaultAsync(m => m.id == id);
            if (r == null)
            {
                return NotFound();
            }

            return View(r);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var r = await _context.Rezervimi.FindAsync(id);
            _context.Klienti.Remove(r);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool RezervimiExists(int id)
        {
            return _context.Rezervimi.Any(e => e.id == id);
        }
    }
}

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
        public async Task<IActionResult> Index(
            int? pageNumber)
        {

            var rezervimet = from s in _context.Rezervimi
                           select s;

            int pageSize = 3;
            return View(await PaginatedList<Rezervimi>.CreateAsync(rezervimet.AsNoTracking(), pageNumber ?? 1, pageSize));
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
        public async Task<IActionResult> Edit(int id, [Bind("id,Klienti_id,Libra_id,Aktiv,created_at,deleted_at")] Rezervimi r)
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

        public IActionResult Rezervo(int libriId)
        {
            Rezervimi rez = new Rezervimi();
            rez.Klienti_id = 2; //Test
            rez.Libra_id = libriId;
            rez.Aktiv = true;
            rez.created_at = DateTime.Now;
            rez.deleted_at = DateTime.Now;
            _context.Rezervimi.Add(rez);
            _context.SaveChanges();

            Libra libri = _context.Libra.Where(t => t.id == libriId).First();
            libri.E_Lire = false;
            _context.Libra.Update(libri);
            _context.SaveChanges();

                
            //Me dergu ne imell
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(
            [Bind("id,Klienti_id,Libra_id,Aktiv")] Rezervimi r)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    r.created_at = DateTime.Now;
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
            _context.Rezervimi.Remove(r);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool RezervimiExists(int id)
        {
            return _context.Rezervimi.Any(e => e.id == id);
        }
    }
}

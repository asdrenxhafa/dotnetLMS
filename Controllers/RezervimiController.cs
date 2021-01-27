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
      
        [HttpGet]

        public IActionResult Create()
        {
            ViewBag.klientetid = _context.Klienti.ToList();
            var librat = _context.Libra.Where(l => l.E_Lire == false).ToList();
            ViewBag.libraid = librat;
            return View();
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
                    r.Aktiv = true;
                    r.created_at = DateTime.Now;
                    _context.Rezervimi.Add(r);
                    Libra libri = _context.Libra.Where(t => t.id == r.Libra_id).First();
                    libri.E_Lire = true;
                    _context.Libra.Update(libri);
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
        public IActionResult Kthe(int id)
        {
            Rezervimi r = _context.Rezervimi.Where(t => t.id == id).First();
            r.created_at = DateTime.Now;
            r.Aktiv = false;
            _context.Rezervimi.Update(r);
            _context.SaveChanges();


            Libra libri = _context.Libra.Where(t => t.id == r.Libra_id).First();
            libri.E_Lire = false;
            _context.Libra.Update(libri);
            _context.SaveChanges();

            return RedirectToAction("Index");
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

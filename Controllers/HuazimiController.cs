using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Libraryms.Models;
using Libraryms.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Libraryms.Controllers
{
    public class HuazimiController : Controller
    {
        // GET: HuazimiController
        private readonly LibrarymsContext _context;

        public HuazimiController(LibrarymsContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? pageNumber)
        { 
            var huazimet = from s in _context.Huazimi
                             select s;

            int pageSize = 3;
            return View(await PaginatedList<Huazimi>.CreateAsync(huazimet.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: HuazimiController/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var huazimi = await _context.Huazimi
                .FirstOrDefaultAsync(m => m.id == id);

            if (huazimi == null)
            {
                return NotFound();
            }

            return View(huazimi);
        }

      

        
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.klientetid = _context.Klienti.ToList();
            var librat = _context.Libra.Where(l => l.E_Lire == true).ToList();
            ViewBag.libraid = librat;
            return View(); 

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DataKthimit,Klienti_id,Libra_id,")] Huazimi huazimi)
        {
            try { 
                if (ModelState.IsValid)
                        {
                            huazimi.DataPritjes = DateTime.Now.AddMonths(1);
                            huazimi.Aktiv = true;
                             _context.Huazimi.Add(huazimi);
                            Libra libri = _context.Libra.Where(t => t.id == huazimi.Libra_id).First();
                            libri.E_Lire = false;
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
                    return View(huazimi);

                }

        public IActionResult Kthe(int id)
        {
            Huazimi huazimi = _context.Huazimi.Where(t => t.id == id).First();
            huazimi.DataKthimit = DateTime.Now;
            huazimi.Aktiv = false;
            _context.Huazimi.Update(huazimi);
            _context.SaveChanges();


            Libra libri = _context.Libra.Where(t => t.id == huazimi.Libra_id).First();
            libri.E_Lire = true;
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

            var r = await _context.Huazimi
                .FirstOrDefaultAsync(m => m.id == id);
            if (r == null)
            {
                return NotFound();
            }

            return View(r);
        }

        // POST: HuazimiController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var r = await _context.Huazimi.FindAsync(id);
            _context.Huazimi.Remove(r);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HuazimiExists(int id)
        {
            return _context.Huazimi.Any(e => e.id == id);
        }
    }
}

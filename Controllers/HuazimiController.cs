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

        // GET: HuazimiController/Create
        public ActionResult Create()
        {
            return View();
        }
        public IActionResult Huazo(int libriId)
        {
            Huazimi huazimi = new Huazimi();
            
            huazimi.DataPritjes = DateTime.Now.AddMonths(1) ;
            huazimi.DataKthimit = DateTime.Now;
            huazimi.Klienti_id = 1;
            huazimi.Libra_id = libriId;
            huazimi.Aktiv = true;
            _context.Huazimi.Add(huazimi);
            _context.SaveChanges();

            Libra libri = _context.Libra.Where(t => t.id == libriId).First();
            libri.E_Lire = false;
            _context.Libra.Update(libri);
            _context.SaveChanges();


            
            return RedirectToAction("Index");
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

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



        // POST: HuazimiController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HuazimiController/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var r = await _context.Huazimi.FindAsync(id);
            if (r == null)
            {
                return NotFound();
            }
            return View(r);
        }

        // POST: HuazimiController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,DataPritjes,DataKthimit,Klienti_id,Libra_id,Aktiv")] Huazimi r)
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
                    if (!HuazimiExists(r.id))
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

        // GET: HuazimiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HuazimiController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private bool HuazimiExists(int id)
        {
            return _context.Huazimi.Any(e => e.id == id);
        }
    }
}

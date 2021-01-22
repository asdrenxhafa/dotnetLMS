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
    
    public class KlientiController : Controller
    {
        private readonly LibrarymsContext _context;


        
        public KlientiController(LibrarymsContext context)
        {
            _context = context;
        }

        

        public async Task<IActionResult> Index(
                string sortOrder,
                string currentFilter,
                string searchString,
                int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["CurrentFilter"] = searchString;

            var klientet = from s in _context.Klienti
                         select s;

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            if (!String.IsNullOrEmpty(searchString))
            {
                klientet = klientet.Where(s => s.Emri.Contains(searchString) || s.Email.Contains(searchString));
            }

            int pageSize = 3;
            return View(await PaginatedList<Klienti>.CreateAsync(klientet.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        //public async Task<IActionResult> IndexAsync()
        //{
        //    return View(await _context.Klienti.ToListAsync());
        //}

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var klientet = await _context.Klienti
                .FirstOrDefaultAsync(m => m.id == id);

            if (klientet == null)
            {
                return NotFound();
            }

            return View(klientet);
        }
      

       
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var k = await _context.Klienti.FindAsync(id);
            if (k == null)
            {
                return NotFound();
            }
            return View(k);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Emri,Email,NumriTel,Aktiv,created_at,deleted_at")] Klienti k)
        {
            if (id != k.id)
            {
            return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(k);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KlientiExists(k.id))
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
            return View(k);
        }

        [HttpGet]
      
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> Create(
            [Bind("Emri,Email,NumriTel,Aktiv")] Klienti k)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(k);
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
            return View(k);

        }
        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var k = await _context.Klienti
                .FirstOrDefaultAsync(m => m.id == id);
            if (k == null)
            {
                return NotFound();
            }

            return View(k);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var k = await _context.Klienti.FindAsync(id);
            _context.Klienti.Remove(k);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool KlientiExists(int id)
        {
            return _context.Klienti.Any(e => e.id == id);
        }
    }
}

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
    
    public class LibraController : Controller
    {

        private readonly LibrarymsContext _context;

        public LibraController(LibrarymsContext context)
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

            var librat = from s in _context.Libra
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
                librat = librat.Where(s => s.Titulli.Contains(searchString) || s.Autori.Contains(searchString));
            }

            //switch (sortOrder)
            //{
            //    case "name_desc":
            //        lirbat = librat.OrderByDescending(s => s.Titulli);
            //        break;
            //    case "Date":
            //        librat = students.OrderBy(s => s.EnrollmentDate);
            //        break;
            //    case "date_desc":
            //        students = students.OrderByDescending(s => s.EnrollmentDate);
            //        break;
            //    default:
            //        students = students.OrderBy(s => s.LastName);
            //        break;
            //}

            int pageSize = 20;
            return View(await PaginatedList<Libra>.CreateAsync(librat.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var libra = await _context.Libra
                .FirstOrDefaultAsync(m => m.id == id);

            if (libra == null)
            {
                return NotFound();
            }

            return View(libra);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("Titulli,Autori")] Libra libra)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    libra.E_Lire = true;
                    libra.huazime = 0;
                    _context.Add(libra);
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
            return View(libra);

        }

        // GET: Movies/Edit/5
        [HttpGet]

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var libra = await _context.Libra.FindAsync(id);
            if (libra == null)
            {
                return NotFound();
            }
            return View(libra);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Titulli,Autori,E_Lire")] Libra libra)
        {
            if (id != libra.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    _context.Update(libra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LibraExists(libra.id))
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
            return View(libra);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var l = await _context.Libra
                .FirstOrDefaultAsync(m => m.id == id);
            if (l == null)
            {
                return NotFound();
            }

            return View(l);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var l = await _context.Libra.FindAsync(id);
            _context.Libra.Remove(l);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LibraExists(int id)
        {
            return _context.Libra.Any(e => e.id == id);
        }

    }
}

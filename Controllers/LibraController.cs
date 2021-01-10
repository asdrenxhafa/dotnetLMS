using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Libraryms.Models;
using Libraryms.Data;
using Microsoft.EntityFrameworkCore;

namespace Libraryms.Controllers
{
    public class LibraController : Controller
    {

        private readonly LibrarymsContext _context;

        public LibraController(LibrarymsContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexAsync()
        {
            return View(await _context.Libra.ToListAsync());
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
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Store(
            [Bind("Titulli,Autori")] Libra libra)
        {
            try
            {
                if (ModelState.IsValid)
                {
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

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Complete(int id)
        {
            
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Undo(int id)
        {

            return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult Edit(Libra item)
        {
            
                return View(item);
           
        }
    }
}

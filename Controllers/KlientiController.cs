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
    public class KlientiController : Controller
    {
        private readonly LibrarymsContext _context;

        public KlientiController(LibrarymsContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> IndexAsync()
        {
            return View(await _context.Klienti.ToListAsync());
        }

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
        [HttpPost]

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
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
        public IActionResult Edit(Klienti item)
        {

            return View(item);

        }
    }
}

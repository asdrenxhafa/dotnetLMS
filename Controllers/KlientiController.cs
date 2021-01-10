using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Libraryms.Models;
using Libraryms.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

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
        public IActionResult Create(Klienti item)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            return View();
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

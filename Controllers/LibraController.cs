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

        [HttpPost]
        public IActionResult Create(Libra item)
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
        public IActionResult Edit(Libra item)
        {
            
                return View(item);
           
        }
    }
}

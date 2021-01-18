using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libraryms.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Libraryms.Controllers
{
    public class RezervimiController : Controller
    {
        private readonly LibrarymsContext _context;

        public RezervimiController(LibrarymsContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> IndexAsync()
        {
            return View(await _context.Rezervimi.ToListAsync());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var klientet = await _context.Rezervimi
                .FirstOrDefaultAsync(m => m.id == id);

            if (klientet == null)
            {
                return NotFound();
            }

            return View(rezervimet);
        }
    }

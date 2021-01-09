using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Libraryms.Data;
using Libraryms.Models;

namespace Libraryms.Areas.Identity.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly Libraryms.Data.LibrarymsContext _context;

        public DetailsModel(Libraryms.Data.LibrarymsContext context)
        {
            _context = context;
        }

        public Libra Libra { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Libra = await _context.Libra.FirstOrDefaultAsync(m => m.id == id);

            if (Libra == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

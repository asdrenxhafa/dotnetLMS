using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Libraryms.Data;
using Libraryms.Models;

namespace Libraryms.Areas.Identity.Pages
{
    public class EditModel : PageModel
    {
        private readonly Libraryms.Data.LibrarymsContext _context;

        public EditModel(Libraryms.Data.LibrarymsContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Libra).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LibraExists(Libra.id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool LibraExists(int id)
        {
            return _context.Libra.Any(e => e.id == id);
        }
    }
}

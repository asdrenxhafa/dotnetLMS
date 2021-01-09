using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Libraryms.Data;
using Libraryms.Models;

namespace Libraryms.Areas.Identity.Pages
{
    public class CreateModel : PageModel
    {
        private readonly Libraryms.Data.LibrarymsContext _context;

        public CreateModel(Libraryms.Data.LibrarymsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Libra Libra { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Libra.Add(Libra);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

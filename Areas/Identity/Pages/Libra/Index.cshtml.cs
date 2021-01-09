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
    public class IndexModel : PageModel
    {
        private readonly Libraryms.Data.LibrarymsContext _context;

        public IndexModel(Libraryms.Data.LibrarymsContext context)
        {
            _context = context;
        }

        public IList<Libra> Libra { get;set; }

        public async Task OnGetAsync()
        {
            Libra = await _context.Libra.ToListAsync();
        }
    }
}

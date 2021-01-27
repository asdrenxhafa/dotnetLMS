using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libraryms.Data;
using Microsoft.AspNetCore.Mvc;

namespace Libraryms.Controllers
{
    public class StatistikaController : Controller
    {
        private readonly LibrarymsContext _context;

        public StatistikaController(LibrarymsContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }


    }
}

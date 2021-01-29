using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libraryms.Data;
using Libraryms.Models;
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

        [HttpGet]

        public ActionResult<IEnumerable<IEnumerable<int>>> Area()
        {
            var jan = 
                _context.Pagesa.Where(p => p.DataEPageses.Month == 1).Select(p => p.Shuma).ToList();

            var feb =
                _context.Pagesa.Where(p => p.DataEPageses.Month == 2).Select(p => p.Shuma).ToList();

            var mar =
                _context.Pagesa.Where(p => p.DataEPageses.Month == 3).Select(p => p.Shuma).ToList();

            var apr =
                _context.Pagesa.Where(p => p.DataEPageses.Month == 4).Select(p => p.Shuma).ToList();

            var may =
                _context.Pagesa.Where(p => p.DataEPageses.Month == 5).Select(p => p.Shuma).ToList();

            var jun =
                _context.Pagesa.Where(p => p.DataEPageses.Month == 6).Select(p => p.Shuma).ToList();

            var jul =
                _context.Pagesa.Where(p => p.DataEPageses.Month == 7).Select(p => p.Shuma).ToList();

            var aug =
                _context.Pagesa.Where(p => p.DataEPageses.Month == 8).Select(p => p.Shuma).ToList();

            var sep =
                _context.Pagesa.Where(p => p.DataEPageses.Month == 9).Select(p => p.Shuma).ToList();

            var oct =
                _context.Pagesa.Where(p => p.DataEPageses.Month == 10).Select(p => p.Shuma).ToList();

            var nov =
                _context.Pagesa.Where(p => p.DataEPageses.Month == 11).Select(p => p.Shuma).ToList();

            var dec =
                _context.Pagesa.Where(p => p.DataEPageses.Month == 12).Select(p => p.Shuma).ToList();


            return new[]
                {
                    jan,
                    feb,
                    mar,
                    apr,
                    may,
                    jun,
                    jul,
                    aug,
                    sep,
                    oct,
                    nov,
                    dec
                };
        }



    }
}

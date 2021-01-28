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

        public ActionResult<IEnumerable<IEnumerable<string>>> Area()
        {
            var jan = 
                _context.Pagesa.Where(p => p.created_at.Month == 1)
                .Select(p => p.shuma).ToList();

            var feb =
                _context.Pagesa.Where(p => p.created_at.Month == 2).Select(p => p.shuma).ToList();

            var mar =
                _context.Pagesa.Where(p => p.created_at.Month == 3).Select(p => p.shuma).ToList();

            var apr =
                _context.Pagesa.Where(p => p.created_at.Month == 4).Select(p => p.shuma).ToList();

            var may =
                _context.Pagesa.Where(p => p.created_at.Month == 5).Select(p => p.shuma).ToList();

            var jun =
                _context.Pagesa.Where(p => p.created_at.Month == 6).Select(p => p.shuma).ToList();

            var jul =
                _context.Pagesa.Where(p => p.created_at.Month == 7).Select(p => p.shuma).ToList();

            var aug =
                _context.Pagesa.Where(p => p.created_at.Month == 8).Select(p => p.shuma).ToList();

            var sep =
                _context.Pagesa.Where(p => p.created_at.Month == 9).Select(p => p.shuma).ToList();

            var oct =
                _context.Pagesa.Where(p => p.created_at.Month == 10).Select(p => p.shuma).ToList();

            var nov =
                _context.Pagesa.Where(p => p.created_at.Month == 11).Select(p => p.shuma).ToList();

            var dec =
                _context.Pagesa.Where(p => p.created_at.Month == 12).Select(p => p.shuma).ToList();


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

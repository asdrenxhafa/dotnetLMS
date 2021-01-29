using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libraryms.Data;
using Libraryms.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Libraryms.Controllers
{
    [Authorize(Roles = "Admin")]
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
        public ActionResult<IEnumerable<int>> Area()
        {
            var jan = 
                _context.Pagesa.Where(p => p.DataEPageses.Month == 1).Select(p => p.Shuma).Sum();

            var feb =
                _context.Pagesa.Where(p => p.DataEPageses.Month == 2).Select(p => p.Shuma).Sum();

            var mar =
                _context.Pagesa.Where(p => p.DataEPageses.Month == 3).Select(p => p.Shuma).Sum();

            var apr =
                _context.Pagesa.Where(p => p.DataEPageses.Month == 4).Select(p => p.Shuma).Sum();

            var may =
                _context.Pagesa.Where(p => p.DataEPageses.Month == 5).Select(p => p.Shuma).Sum();

            var jun =
                _context.Pagesa.Where(p => p.DataEPageses.Month == 6).Select(p => p.Shuma).Sum();

            var jul =
                _context.Pagesa.Where(p => p.DataEPageses.Month == 7).Select(p => p.Shuma).Sum();

            var aug =
                _context.Pagesa.Where(p => p.DataEPageses.Month == 8).Select(p => p.Shuma).Sum();

            var sep =
                _context.Pagesa.Where(p => p.DataEPageses.Month == 9).Select(p => p.Shuma).Sum();

            var oct =
                _context.Pagesa.Where(p => p.DataEPageses.Month == 10).Select(p => p.Shuma).Sum();

            var nov =
                _context.Pagesa.Where(p => p.DataEPageses.Month == 11).Select(p => p.Shuma).Sum();

            var dec =
                _context.Pagesa.Where(p => p.DataEPageses.Month == 12).Select(p => p.Shuma).Sum();


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


        //[HttpGet]
        //public ActionResult<IEnumerable<Libra>> Pie()
        //{
        //    //   string sqlString = "SELECT Titulli from Libra where id = (SELECT Libra_id FROM Huazimi GROUP BY Libra_id ORDER BY COUNT(*) desc LIMIT 1)";

        //    var libs =
        //        _context.Libra.OrderByDescending(l => l.huazime).Take(3).ToArray();


        //    return new[]
        //        {
        //            libs[0],
        //            libs[1],
        //            libs[2]
        //        };
        //}



    }
}

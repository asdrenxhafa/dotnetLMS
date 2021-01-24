using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Libraryms.Controllers
{
    public class StatistikaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

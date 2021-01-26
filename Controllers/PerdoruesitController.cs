using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Libraryms.Controllers
{
    public class PerdoruesitController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        public PerdoruesitController(UserManager<IdentityUser> userManager)
        {

            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var user = userManager.Users;
            return View(user);
        }
    }
}

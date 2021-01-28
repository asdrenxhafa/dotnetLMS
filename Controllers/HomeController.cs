using Libraryms.Data;
using Libraryms.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace Libraryms.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly LibrarymsContext _context;
        private readonly SignInManager<IdentityUser> _signInManager;
        public HomeController(UserManager<IdentityUser> userManager, 
            SignInManager<IdentityUser> signInManager, LibrarymsContext context)
        {

            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(Login model , string returnUrl)
        {

            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user != null)
            {

                var signInresult = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);

                if (signInresult.Succeeded)
                {
                    var pagesat = _context.Pagesa.ToList();
                    foreach(Pagesa p in pagesat)
                    {
                        if(p.DataEPageses == p.DataESkadimit)
                        {
                            p.Active = false;
                            _context.Pagesa.Update(p);
                            var klienti = _context.Klienti.Where(k => k.id == p.Klienti_id).First();
                            klienti.Aktiv = false;
                            _context.Klienti.Update(klienti);
                            _context.SaveChanges();
                        }
                    }

                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "home");
                    }
                }

                    ModelState.AddModelError(string.Empty,"Invalid Login Attempt");
                

            }

            return View(model);
        }
       
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(Register model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.Name, Email = model.Email };
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "home");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }
       
    }
}

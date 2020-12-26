using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Libraryms.Controllers
{
    public class PagesaController : Controller
    {
        // GET: PagesaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PagesaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PagesaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PagesaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PagesaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PagesaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PagesaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PagesaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Libraryms.Controllers
{
    public class HuazimiController : Controller
    {
        // GET: HuazimiController
        public ActionResult Index()
        {
            // ViewData["Huazimi"] = products;

            return View();
        }

        // GET: HuazimiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HuazimiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HuazimiController/Create
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

        // GET: HuazimiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HuazimiController/Edit/5
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

        // GET: HuazimiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HuazimiController/Delete/5
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

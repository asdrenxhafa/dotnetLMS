using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Libraryms.Controllers
{
    public class KlientiController : Controller
    {
        // GET: KlientiController
        public ActionResult Index()
        {
            return View();
        }

        // GET: KlientiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KlientiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KlientiController/Create
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

        // GET: KlientiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KlientiController/Edit/5
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

        // GET: KlientiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KlientiController/Delete/5
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

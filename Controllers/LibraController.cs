using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Libraryms.Controllers
{
    public class LibraController : Controller
    {
        // GET: LibraController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LibraController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LibraController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LibraController/Create
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

        // GET: LibraController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LibraController/Edit/5
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

        // GET: LibraController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LibraController/Delete/5
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

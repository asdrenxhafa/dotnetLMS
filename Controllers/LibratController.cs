using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Libraryms.Models;

namespace Libraryms.Controllers
{
    public class LibratController : Controller
    {
        public IActionResult List()
        {
            return View(Data.LibratList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(LibratItem item)
        {
            if (ModelState.IsValid)
            {
                item.Id = Guid.NewGuid();
                Data.LibratList.Add(item);

                return RedirectToAction("List");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var item = Data.LibratList.SingleOrDefault(x => x.Id == id);

            return View(item);
        }

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            var item = Data.LibratList.SingleOrDefault(x => x.Id == id);
            Data.LibratList.Remove(item);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Complete(Guid id)
        {
            var item = Data.LibratList.SingleOrDefault(x => x.Id == id);
            item.E_Lire = true;
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Undo(Guid id)
        {
            var item = Data.LibratList.SingleOrDefault(x => x.Id == id);
            item.E_Lire = false;
            return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult Edit(LibratItem item)
        {
            if (ModelState.IsValid)
            {
                var origianlItem = Data.LibratList.SingleOrDefault(x => x.Id == item.Id);
                origianlItem.Titulli = item.Titulli;
                origianlItem.Autori = item.Autori;

                return RedirectToAction("List");
            }
            else
            {
                return View(item);
            }
        }
    }
}

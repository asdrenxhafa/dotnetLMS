using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Libraryms.Models;

namespace Libraryms.Controllers
{
    public class KlientiController : Controller
    {
       
        public IActionResult Index()
        {
            return View(Data.KlientiList);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

      
        [HttpPost]
        public IActionResult Create(Klienti klienti)
        {
            if (ModelState.IsValid)
            {
                klienti.Id = Guid.NewGuid();
                Data.KlientiList.Add(klienti);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var item = Data.KlientiList.SingleOrDefault(x => x.Id == id);

            return View(item);
        }

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            var item = Data.KlientiList.SingleOrDefault(x => x.Id == id);
            Data.KlientiList.Remove(item);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Complete(Guid id)
        {
            var item = Data.KlientiList.SingleOrDefault(x => x.Id == id);
            item.Aktiv = true;

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Undo(Guid id)
        {
            var item = Data.KlientiList.SingleOrDefault(x => x.Id == id);
            item.Aktiv = false;

            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Edit(Klienti item)
        {
            if (ModelState.IsValid)
            {
                var origianlItem = Data.KlientiList.SingleOrDefault(x => x.Id == item.Id);
                origianlItem.Emri = item.Emri;
                origianlItem.Email = item.Email;
                origianlItem.NumriTel = item.NumriTel;
                return RedirectToAction("List");
            }
            else
            {
                return View(item);
            }
        }
    }
}

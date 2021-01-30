using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Libraryms.Models;
using Libraryms.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Mail;

namespace Libraryms.Controllers
{
    public class HuazimiController : Controller
    {
        // GET: HuazimiController
        private readonly LibrarymsContext _context;

        public HuazimiController(LibrarymsContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? pageNumber)
        { 
            var huazimet = from s in _context.Huazimi
                             select s;

            int pageSize = 10;
            return View(await PaginatedList<Huazimi>.CreateAsync(huazimet.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: HuazimiController/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var huazimi = await _context.Huazimi
                .FirstOrDefaultAsync(m => m.id == id);

            if (huazimi == null)
            {
                return NotFound();
            }

            return View(huazimi);
        }

      

        
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.klientetid = _context.Klienti.Where(k => k.Aktiv==true).ToList();
            var librat = _context.Libra.Where(l => l.E_Lire == true).ToList();
            ViewBag.libraid = librat;
            return View(); 

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DataKthimit,Klienti_id,Libra_id,")] Huazimi huazimi)
        {
            try { 
                if (ModelState.IsValid)
                        {
                            huazimi.DataPritjes = DateTime.Now.AddMonths(1);
                            huazimi.Aktiv = true;
                             _context.Huazimi.Add(huazimi);
                            Libra libri = _context.Libra.Where(t => t.id == huazimi.Libra_id).First();
                            libri.E_Lire = false;
                            libri.huazime++;
                             _context.Libra.Update(libri);
                    await _context.SaveChangesAsync();
                            return RedirectToAction(nameof(Index));
                        }
                    }
                    catch (DbUpdateException /* ex */)
                    {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                            "Try again, and if the problem persists " +
                            "see your system administrator.");
                    }
                    return View(huazimi);

                }

        public IActionResult Kthe(int id)
        {
            Huazimi huazimi = _context.Huazimi.Where(t => t.id == id).First();
            huazimi.DataKthimit = DateTime.Now;
            huazimi.Aktiv = false;
            _context.Huazimi.Update(huazimi);
            _context.SaveChanges();


            Libra libri = _context.Libra.Where(t => t.id == huazimi.Libra_id).First();
            libri.E_Lire = true;
            _context.Libra.Update(libri);
            _context.SaveChanges();
            var rez = _context.Rezervimi.Where(r => r.Aktiv == true).ToList();
            foreach (Rezervimi r in rez)
            {
                if(huazimi.Libra_id == r.Libra_id)
                {
                    var klienti = _context.Klienti.Where(k => k.id == r.Klienti_id).First();
                    var libra = _context.Libra.Where(k => k.id == r.Libra_id).First();
                    MailMessage mail = new MailMessage("projektilibrary@gmail.com", klienti.Email);
                    mail.Subject = "Rezervimi I Librit " + libra.Titulli;
                    mail.Body = "Pershendetje , Ju informojme se librin " + libra.Titulli+ " qe keni rezervuar tashme eshte i lire dhe mund te vini ta merrni Librin";
                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                    smtpClient.Credentials = new System.Net.NetworkCredential()
                    {
                        UserName = "projektilibrary@gmail.com",
                        Password = "projektilibrary123"
                    };
                    smtpClient.EnableSsl = true;
                    smtpClient.Send(mail);

                }
            }
       

            return RedirectToAction("Index");
        }


   
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var r = await _context.Huazimi
                .FirstOrDefaultAsync(m => m.id == id);
            if (r == null)
            {
                return NotFound();
            }

            return View(r);
        }

        // POST: HuazimiController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var r = await _context.Huazimi.FindAsync(id);
            _context.Huazimi.Remove(r);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HuazimiExists(int id)
        {
            return _context.Huazimi.Any(e => e.id == id);
        }
    }
}

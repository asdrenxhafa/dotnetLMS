using Libraryms.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libraryms.Data
{
    public class DbInit
    {

        public static void Initialize(LibrarymsContext context)
        {
            context.Database.EnsureCreated();

            //Look for any students.
            if (context.Libra.Any() || context.Klienti.Any() || context.Roles.Any())
            {
               return;   // DB has been seeded
            }
            



            var lirbat = new Libra[]
            {
            new Libra{Titulli = "When Harry Met Sally", Autori = "Filan Fisteku", E_Lire = true,} };

            foreach (Libra s in lirbat)
            {
                context.Libra.Add(s);
            }
            context.SaveChanges();

            var klientet = new Klienti[]
            {
                new Klienti{Emri="Leutrim Ahmeti" , Email="la43824@ubt-uni.net" , Aktiv=true ,NumriTel="044444444"},
            };
            foreach (Klienti k in klientet)
            {
                context.Klienti.Add(k);
            }
            context.SaveChanges();

            var rezervimi = new Rezervimi[]
           {
                new Rezervimi{Klienti_id=1 , Libra_id=2 , Aktiv=true}
           };
            foreach (Rezervimi r in rezervimi)
            {
                context.Rezervimi.Add(r);
            }
            context.SaveChanges();

            var roles = new IdentityRole[] {
                new IdentityRole{Name="Admin"},
                new IdentityRole{Name="User"}
            };
            foreach(IdentityRole r in roles)
            {
                context.Roles.Add(r);
            }
            context.SaveChanges();

            var pagesa = new Pagesa[]
           {
                new Pagesa{ shuma="5euro" , Klienti_id="1" , Active=true}
           };
            foreach (Pagesa p in pagesa)
            {
                context.Pagesa.Add(p);
            }
            context.SaveChanges();


        }
    }
}

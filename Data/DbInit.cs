using Libraryms.Models;
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

            // Look for any students.
            if (context.Libra.Any())
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
           
            
        }

    }
}

using Libraryms.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libraryms.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LibrarymsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LibrarymsContext>>()))
            {
                // Look for any movies.
                if (context.Libra.Any())
                {
                    return;   // DB has been seeded
                }

                context.Libra.AddRange(
                    new Libra
                    {
                        Titulli = "When Harry Met Sally",
                        Autori = "Filan Fisteku",
                        E_Lire = true,
                    },

                    new Libra
                    {
                        Titulli = "When Harry Met Sally 1",
                        Autori = "Asdren Xhafa",
                        E_Lire = true,
                    },

                    new Libra
                    {
                        Titulli = "When Harry Met Sally 2",
                        Autori = "Filan Fistekinjo",
                        E_Lire = true,
                    },

                    new Libra
                    {
                        Titulli = "When Harry Met Sally 3",
                        Autori = "Filan Fisteka",
                        E_Lire = true,
                    }
                );
                context.SaveChanges();
            } 
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libraryms.Models;

namespace Libraryms
{
    public class Data
    {
        public static List<LibratItem> LibratList { get; set; }

        static Data()
        {
            LibratList = new List<LibratItem>();

            LibratList.Add(new LibratItem
            {
                Id = Guid.NewGuid(),
                Titulli = "Asdreni",
                Autori = "Asdren Xhafa",
                E_Lire = true
            });

            LibratList.Add(new LibratItem
            {
                Id = Guid.NewGuid(),
                Titulli = "Asdreni",
                Autori = "Asdren Xhafa",
                E_Lire = true
            });

            LibratList.Add(new LibratItem
            {
                Id = Guid.NewGuid(),
                Titulli = "Asdreni",
                Autori = "Asdren Xhafa",
                E_Lire = true
            });

            LibratList.Add(new LibratItem
            {
                Id = Guid.NewGuid(),
                Titulli = "Asdreni",
                Autori = "Asdren Xhafa",
                E_Lire = true
            });

            LibratList.Add(new LibratItem
            {
                Id = Guid.NewGuid(),
                Titulli = "Asdreni",
                Autori = "Asdren Xhafa",
                E_Lire = true
            });

            LibratList.Add(new LibratItem
            {
                Id = Guid.NewGuid(),
                Titulli = "Asdreni",
                Autori = "Asdren Xhafa",
                E_Lire = true
            });

            LibratList.Add(new LibratItem
            {
                Id = Guid.NewGuid(),
                Titulli = "Asdreni",
                Autori = "Asdren Xhafa",
                E_Lire = true
            });

        }
    }
}

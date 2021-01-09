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
        public static List<Klienti> KlientiList { get; set; }
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


            KlientiList = new List<Klienti>();
            KlientiList.Add(new Klienti
            {
                Id = Guid.NewGuid(),
                Emri = "Leutrim Ahmeti",
                Email = "email@email.com",
                NumriTel="049111111",
                Aktiv=true
                
            });
            KlientiList.Add(new Klienti
            {
                Id = Guid.NewGuid(),
                Emri = "Leutrim Ahmeti",
                Email = "email@email.net",
                NumriTel = "044222222",
                Aktiv = false

            });
            KlientiList.Add(new Klienti
            {
                Id = Guid.NewGuid(),
                Emri = "Leutrim Ahmeti",
                Email = "email@email.org",
                NumriTel = "045333333",
                Aktiv = false

            });
            KlientiList.Add(new Klienti
            {
                Id = Guid.NewGuid(),
                Emri = "Leutrim Ahmeti",
                Email = "email@ubt-uni.net",
                NumriTel = "044999999",
                Aktiv = true

            });





        }
    }
}

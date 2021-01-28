using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libraryms.Models
{
    public class Pagesa
    {
        public int id { get; set; }

        // [Required]
        // [MinLength(5)]
        public int Shuma { get; set; }
        public int Klienti_id { get; set; }
        public bool Active { get; set; }
        public DateTime DataEPageses { get; set; }

        public DateTime DataESkadimit { get; set; }
    }
}

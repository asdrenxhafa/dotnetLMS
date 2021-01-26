using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libraryms.Models
{
    public class Huazimi
    {
        public int id { get; set; }

        // [Required]
        // [MinLength(5)]
        public DateTime DataPritjes { get; set; }
        public DateTime DataKthimit { get; set; }
        public int Klienti_id { get; set; }
        public int Libra_id { get; set; }
        public bool Aktiv { get; set; }

    }
}

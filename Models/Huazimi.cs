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
        public string DataPritjes { get; set; }
        public string DataKthimit { get; set; }
        public int Klienti_id { get; set; }
        public int Libra_id { get; set; }
        public bool Aktiv { get; set; }

    }
}

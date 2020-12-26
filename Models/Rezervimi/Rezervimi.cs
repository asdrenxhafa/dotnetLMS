using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libraryms.Models.Rezervimi
{
    public class Rezervimi
    {
        public Guid Id { get; set; }

        // [Required]
        // [MinLength(5)]
        public int Klienti_id { get; set; }
        public int Libra_id { get; set; }
        public bool Aktiv { get; set; }
        public DateTime created_at { get; set; }
        public DateTime deleted_at { get; set; }
    }
}

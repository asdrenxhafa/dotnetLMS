using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Libraryms.Models
{
    public class Rezervimi
    {
        public int id { get; set; }

        [Required]
  
        public int Klienti_id { get; set; }
        public int Libra_id { get; set; }
        public bool Aktiv { get; set; }
        public DateTime created_at { get; set; }
        public DateTime deleted_at { get; set; }
    }
}

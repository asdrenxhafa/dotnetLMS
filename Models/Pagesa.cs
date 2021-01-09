using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libraryms.Models.Pagesa
{
    public class Pagesa
    {
        public int id { get; set; }

        // [Required]
        // [MinLength(5)]
        public string shuma { get; set; }
        public string Klienti_id { get; set; }
        public bool Active { get; set; }
        public DateTime created_at { get; set; }
        public DateTime deleted_at { get; set; }
    }
}

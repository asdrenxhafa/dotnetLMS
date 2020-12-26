using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libraryms.Models.Klienti
{
    public class Klienti
    {

        public Guid Id { get; set; }

        // [Required]
        // [MinLength(5)]
        public string Emri { get; set; }
        public string Email { get; set; }
        public string NumriTel { get; set; }
        public bool Aktiv { get; set; }
        public DateTime created_at { get; set; }
        public DateTime deleted_at { get; set; }
    }
}

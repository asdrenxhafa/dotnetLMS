using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Libraryms.Models
{
    public class Klienti
    {

        public int id { get; set; }

        [Required]
        // [MinLength(5)]
        public string Emri { get; set; }
        [Required]
        public string Email { get; set; }
        public string NumriTel { get; set; }
        [Required]
        public bool Aktiv { get; set; }
        public DateTime created_at { get; set; }
        public DateTime deleted_at { get; set; }
    }
}

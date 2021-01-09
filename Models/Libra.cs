using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Libraryms.Models
{
    public class Libra
    {
        public int id { get; set; }

        [Required]
        public string Titulli { get; set; }
        public string Autori { get; set; }
        public bool E_Lire { get; set; }
    }
}

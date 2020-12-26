using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libraryms.Models.Libra
{
    public class Libra
    {
        public Guid Id { get; set; }

        // [Required]
        // [MinLength(5)]
        public string Titulli { get; set; }
        public string Rafti_id { get; set; }
        public string Autori { get; set; }
        public bool E_Lire { get; set; }
        public DateTime created_at { get; set; }
        public DateTime deleted_at { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libraryms.Models.Rafti
{
    public class Rafti
    {
        public Guid Id { get; set; }

        // [Required]
        // [MinLength(5)]
        public string Rreshti { get; set; }
        public DateTime created_at { get; set; }
        public DateTime deleted_at { get; set; }
    }
}

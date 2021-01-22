using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Libraryms.Models
{
    public class CreateRole
    {
        public int id { get; set; }
        [Required]
        public string RoleId { get; set; }
    }
}

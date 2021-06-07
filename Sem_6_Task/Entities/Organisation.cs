using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    class Organisation
    {
        public int Id { get; set; }

        [Required]
        public Address Address { get; set; }
        public List<Service> Services { get; set; }
    }
}

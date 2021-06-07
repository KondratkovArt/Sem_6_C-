using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Organisation
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        public Address Address { get; set; }
        public List<Service> Services { get; set; }
    }
}

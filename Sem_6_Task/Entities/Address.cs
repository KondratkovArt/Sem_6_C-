using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string FlatNumber { get; set; }

        [Required]
        public int CityId { get; set; }
        public virtual City City { get; set; }
    }
}

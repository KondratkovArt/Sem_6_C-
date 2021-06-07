using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string NSP { get; set; }

        [Required]
        public Address Address { get; set; }

    }
}

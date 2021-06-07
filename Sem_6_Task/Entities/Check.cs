using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Check
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Sum { get; set; }

        [Required]
        public Client Client { get; set; }
        public Organisation Organisation { get; set; }
        public Service Service { get; set; }
    }
}

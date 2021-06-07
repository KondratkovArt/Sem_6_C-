using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Meter
    {
        public int Id { get; set; }
        public string ServiceNaming { get; set; }
        public double PreviousVal { get; set; }
        public double CurrentVal { get; set; }

        [Required]
        public Client Client { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    class Client
    {
        public int Id { get; set; }
        public string NSP { get; set; }

        [Required]
        public Address address;

    }
}

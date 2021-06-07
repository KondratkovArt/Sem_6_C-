using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class CountryDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }
        

        public CountryDTO(Country country)
        {
            Id = country.Id;
            Name = country.Name;
        }

        public CountryDTO()
        {

        }
    }
}

using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    class CityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }


        public CityDTO(City city)
        {
            Id = city.Id;
            Name = city.Name;
            CountryId = city.Country.Id;
        }

        public CityDTO()
        {

        }
    }
}

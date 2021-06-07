using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class AddressDTO
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string FlatNumber { get; set; }
        public int CityId { get; set; }
        

        public AddressDTO(Address address)
        {
            Id = address.Id;
            Street = address.Street;
            HouseNumber = address.HouseNumber;
            FlatNumber = address.FlatNumber;
            CityId = address.City.Id;
        }


    }
}

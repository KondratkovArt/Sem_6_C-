using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IAddressService
    {
        void CreateAddress(AddressDTO address);
        AddressDTO GetAddressById(int id);
        AddressDTO GetAddressByStreetHouseFlat(string street, string houseNumber, string flatNumber);
        IEnumerable<AddressDTO> GetAddressess();
        IEnumerable<ClientDTO> GetClientDTOByAddressId(int id);
        IEnumerable<ClientDTO> GetClientDTOByAddressId(str);
    }
}

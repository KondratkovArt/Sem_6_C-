using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class ClientDTO
    {

        public int Id { get; set; }
        public string NSP { get; set; }
        public int AddressId { get; set; }

        public ClientDTO(Client client)
        {
            Id = client.Id;
            NSP = client.NSP;
            AddressId = client.Address.Id;
        }

        public ClientDTO()
        {

        }
    }
}

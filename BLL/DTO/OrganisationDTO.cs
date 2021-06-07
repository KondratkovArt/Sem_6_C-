using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    class OrganisationDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public List<ServiceDTO> ServiceDTOs { get; set; }

        public OrganisationDTO(Organisation organisation, List<ServiceDTO> services)
        {
            Id = organisation.Id;
            Name = organisation.Name;
            AddressId = organisation.Address.Id;
            ServiceDTOs = services;
        }
    }
}

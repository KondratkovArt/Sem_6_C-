using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class CheckDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Sum { get; set; }
        public int ClientId { get; set; }
        public int OrganisationId{ get; set; }
        public string ServiceName{ get; set; }

        public CheckDTO(Check check)
        {
            Id = check.Id;
            Date = check.Date;
            Sum = check.Sum;
            ClientId = check.Client.Id;
            OrganisationId = check.Organisation.Id;
            ServiceName = check.Service.Naming;
        }
    }
}

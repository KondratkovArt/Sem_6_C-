using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    class MeterDTO
    {
        public int Id { get; set; }
        public string ServiceNaming { get; set; }
        public double PreviousVal { get; set; }
        public double CurrentVal { get; set; }
        public int ClientId { get; set; }

        public MeterDTO(Meter meter)
        {
            Id = meter.Id;
            ServiceNaming = meter.ServiceNaming;
            PreviousVal = meter.PreviousVal;
            CurrentVal = meter.CurrentVal;
            ClientId = meter.Client.Id;
        }

        public MeterDTO()
        {

        }
    }
}

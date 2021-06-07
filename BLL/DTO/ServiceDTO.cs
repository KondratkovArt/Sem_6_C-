using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class ServiceDTO
    {
        public string Naming { get; set; }
        public string Unit { get; set; }
        public double CostOfUnit { get; set; }

        public ServiceDTO(Service service)
        {
            Naming = service.Naming;
            Unit = service.Unit;
            CostOfUnit = service.CostOfUnit;
        }
        public ServiceDTO()
        {

        }
    }
}

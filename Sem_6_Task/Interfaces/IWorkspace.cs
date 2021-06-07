using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IWorkspace : IDisposable
    {
        IRepository<City> Cities { get; }
        IRepository<Address> Addresses { get; }
        IRepository<Check> Checks{ get; }
        IRepository<Client> Clients { get; }
        IRepository<Country> Countries { get; }
        IRepository<Meter> Meters { get; }
        IRepository<Organisation> Organisations { get; }
        IRepository<Service> Services { get; }
        void Save();
    }
}
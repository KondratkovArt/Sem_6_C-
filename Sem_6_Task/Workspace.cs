using DAL.EF;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Workspace
    {
        private MyContext db;

        private IRepository<Address> _addressRepo;
        private IRepository<Check> _checkRepo;
        private IRepository<City> _cityRepo;
        private IRepository<Client> _clientRepo;
        private IRepository<Country> _countryRepo;
        private IRepository<Meter> _meterRepo;
        private IRepository<Organisation> _organisationRepo;
        private IRepository<Service> _serviceRepo;

        public Workspace(string connection)
        {
            db = new MyContext(connection);
        }

        public IRepository<Address> Addresses
        {
            get
            {
                if (_addressRepo == null)
                    _addressRepo = new Repository<Address>(db);
                return _addressRepo;
            }
        }

        public IRepository<Check> Checks
        {
            get
            {
                if (_checkRepo == null)
                    _checkRepo = new Repository<Check>(db);
                return _checkRepo;
            }
        }


        public IRepository<City> Cities
        {
            get
            {
                if (_cityRepo == null)
                    _cityRepo = new Repository<City>(db);
                return _cityRepo;
            }
        }


        public IRepository<Client> Clients
        {
            get
            {
                if (_clientRepo == null)
                    _clientRepo = new Repository<Client>(db);
                return _clientRepo;
            }
        }

        public IRepository<Country> Countries
        {
            get
            {
                if (_countryRepo == null)
                    _countryRepo = new Repository<Country>(db);
                return _countryRepo;
            }
        }

        public IRepository<Meter> Meters
        {
            get
            {
                if (_meterRepo == null)
                    _meterRepo = new Repository<Meter>(db);
                return _meterRepo;
            }
        }

        public IRepository<Organisation> Organisations
        {
            get
            {
                if (_organisationRepo == null)
                    _organisationRepo = new Repository<Organisation>(db);
                return _organisationRepo;
            }
        }

        public IRepository<Service> Services
        {
            get
            {
                if (_serviceRepo == null)
                    _serviceRepo = new Repository<Service>(db);
                return _serviceRepo;
            }
        }


        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

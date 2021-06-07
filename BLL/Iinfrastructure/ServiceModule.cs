using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DAL.Interfaces;

namespace BLL.Infrastructure
{
    class ServiceModule : NinjectModule
    {
        private string _connectionString;
        public ServiceModule(string connection)
        {
            _connectionString = connection;
        }
        public override void Load()
        {
            Bind<IWorkspace>().To<Workspace>().WithConstructorArgument(_connectionString);
        }
    }
}
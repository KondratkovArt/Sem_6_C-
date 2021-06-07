using DAL.Entities;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    class MyContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Check> Checks { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Meter> Meters { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<Service> Services { get; set; }

        private readonly string _connectionString;
        public MyContext(string connectionString)
        {
            _connectionString = connectionString;

            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductPrice>().HasKey(pp => new { pp.ProductId, pp.RentStoreId });
        }
    }
}

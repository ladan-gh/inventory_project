using LadanANDAsma.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LadanANDAsma
{
    public class DataBase : DbContext
    {
        public DataBase(DbContextOptions options) : base(options)
        {
        }

        public DataBase()
        {
        }
        public DbSet<anbar> anbars { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<exit> exits { get; set; }
        public DbSet<fctor> factors { get; set; }
        public DbSet<kala> kalas { get; set; }
        public DbSet<mojavez> mojavezs { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<referred> referres { get; set; }
        public DbSet<residKala> resids { get; set; }
    }
}

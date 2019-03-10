using Cuscuzeria.Domain;
using Cuscuzeria.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cuscuzeria.Infra.Data.Context
{
    public class CuscuzeriaContext : DbContext
    {
        //Mapping Classes to Database Tables
        public DbSet<Accompaniment> Accompaniments { get; set; }
        public DbSet<Beverage> Beverages { get; set; }
        public DbSet<Cuscuz> Cuscuz { get; set; }
        public DbSet<Cuscuzeiro> Cuscuzeiros { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Promo> Promos { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<User> Users { get; set; }

        //by Convention
        public CuscuzeriaContext(DbContextOptions options) : base(options)
        {

        }
    }
}

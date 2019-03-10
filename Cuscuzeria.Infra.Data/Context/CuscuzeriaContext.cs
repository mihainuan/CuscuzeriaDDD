using Cuscuzeria.Domain;
using Cuscuzeria.Domain.Entities;
using Cuscuzeria.Infra.Data.Config;
using Microsoft.EntityFrameworkCore;
using Type = Cuscuzeria.Domain.Entities.Type;

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

        //Mapping by Convention
        public CuscuzeriaContext(DbContextOptions options) : base(options)
        {

        }

        //Mapping by Configuration (EF6)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Configuration of 'accompaniments'
            modelBuilder.ApplyConfiguration(new AccompanimentConfiguration());

            //Configuration of 'beverages'
            modelBuilder.ApplyConfiguration(new BeverageConfiguration());

            //Configuration of 'cuscuz'
            modelBuilder.ApplyConfiguration(new CuscuzConfiguration());

            //Configuration of 'cuscuzeiros'
            modelBuilder.ApplyConfiguration(new CuscuzeiroConfiguration());

            //Configuration of 'drinks'
            modelBuilder.ApplyConfiguration(new DrinkConfiguration());

            //Configuration of 'orders'
            modelBuilder.ApplyConfiguration(new OrderConfiguration());

            //Configuration of 'promos'
            modelBuilder.ApplyConfiguration(new PromoConfiguration());

            //Configuration of 'types'
            modelBuilder.ApplyConfiguration(new TypeConfiguration());

            //Configuration of 'users'
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            //Apply configurations
            base.OnModelCreating(modelBuilder);
        }
    }
}

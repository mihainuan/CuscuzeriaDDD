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
        public virtual DbSet<Accompaniment> Accompaniments { get; set; }
        public virtual DbSet<Beverage> Beverages { get; set; }
        public virtual DbSet<Cuscuz> Cuscuz { get; set; }
        public virtual DbSet<Cuscuzeiro> Cuscuzeiros { get; set; }
        public virtual DbSet<Drink> Drinks { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Promo> Promos { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<User> Users { get; set; }

        //Mapping by Convention
        public CuscuzeriaContext(DbContextOptions options) : base(options)
        {

        }
        //public CuscuzeriaContext()
        //{

        //}

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
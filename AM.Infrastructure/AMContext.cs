 using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class AMContext: DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
Initial Catalog=SalmaAzaiezDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Plane> Planes { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Traveller> Travellers { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new PlaneConfuguration());
            modelbuilder.ApplyConfiguration(new FlightConfiguration());
            modelbuilder.ApplyConfiguration(new PassengerConfiguration());
            modelbuilder.Entity<Staff>().ToTable("Staff");
            modelbuilder.Entity<Traveller>().ToTable("Traveller");
            modelbuilder.ApplyConfiguration(new TicketConfiguration());
        } 
        protected override void ConfigureConventions(ModelConfigurationBuilder modelConfiguration)
        {
            modelConfiguration.Properties<DateTime>().HaveColumnType("date");  /* ON A CHANGE LE TYPE DATETIME2 DE TOUTES LES PROPRIEETES QUI ONT UN TYPE DATETIME EN DATE*/
           
            /* EXP JE VEUX CONFIGURER TOUTES LES PROP DE TYPE STRING POUR AVOIR UNE LONGUER MAX DE 50
             * DONC ON FAIT modelConficuration.Properties<String>.HasMaxLenght(50).*/



        }

    }
} 
  
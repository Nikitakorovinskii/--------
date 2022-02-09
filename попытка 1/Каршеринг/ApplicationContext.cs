
using Microsoft.EntityFrameworkCore;
using Nikita;
using System.Data.SqlClient;

namespace Каршеринг
{

        public class ApplicationContext : DbContext
        {
            public DbSet<Car> Cars { get; set; }
            public DbSet<Client> Clients { get; set; }
            public DbSet<Fine> Fines { get; set; }
            public DbSet<PayCar> PayCars { get; set; }
            public DbSet<Trip> Trips { get; set; }
            public DbSet<Contract> Contracts { get; set; }

            public DbSet<GasStation> GasStations { get; set; }
            public ApplicationContext()
            {
                Database.EnsureCreated();
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=car_rent;Username=postgres;Password=9090");
            }
        }

    }


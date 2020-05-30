using Microsoft.EntityFrameworkCore;
using CarClubAPI.Models;

namespace CarClubAPI.Data
{
    public class CarClubContext : DbContext
    {
        public CarClubContext(DbContextOptions<CarClubContext> options)
        : base(options)
        {

        }

        public DbSet<Vehicle> Vehicles {get;set;}
        public DbSet<PlateNumber> PlateNumbers {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<PlateNumber>()
                .HasOne<Vehicle>(s => s.Vehicle)
                .WithOne(ad => ad.PlateNumber)
                .HasForeignKey<Vehicle>(ad => ad.Id);

            modelBuilder.Entity<Vehicle>(
                v => {
                    v.HasKey(v => v.Id);
                }
            );

            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle {
                    Id = 1,
                    Make = "Toyota",
                    Model = "Corolla"
                },
                new Vehicle {
                    Id = 2,
                    Make = "Nissan",
                    Model = "Micra"
                },
                new Vehicle {
                    Id = 3,
                    Make = "Honda",
                    Model = "Jazz"
                },
                new Vehicle {
                    Id = 4,
                    Make = "Suzuki",
                    Model = "Swift"
                }
            );

            modelBuilder.Entity<PlateNumber>().HasData(
                new PlateNumber {
                    Id = 1,
                    Number = "ABC123",
                    VehicleId = 1
                },
                new PlateNumber {
                    Id = 2,
                    Number = "DEF456",
                    VehicleId = 2
                },
                new PlateNumber {
                    Id = 3,
                    Number = "GHI789",
                    VehicleId = 3
                },
                new PlateNumber {
                    Id = 4,
                    Number = "JKLC098",
                    VehicleId = 4
                }
            );
        }

    }
}

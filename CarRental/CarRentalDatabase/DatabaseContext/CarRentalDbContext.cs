using CarRentalEntities;
using Microsoft.EntityFrameworkCore;

namespace CarRentalDatabase.DatabaseContext
{
    public class CarRentalDbContext : DbContext
    {
        public DbSet<AuthUser> AuthUsers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleImages> VehicleImages { get; set; }

        public CarRentalDbContext(DbContextOptions<CarRentalDbContext> options): base(options)
        {

        }
    }
}

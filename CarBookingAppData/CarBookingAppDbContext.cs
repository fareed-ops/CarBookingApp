using Microsoft.EntityFrameworkCore;

namespace CarBookingAppData
{
    public class CarBookingAppDbContext : DbContext
    {
        public CarBookingAppDbContext(DbContextOptions<CarBookingAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Make> Makes { get; set; }
    }
}

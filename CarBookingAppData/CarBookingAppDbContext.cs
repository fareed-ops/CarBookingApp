using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarBookingAppData
{
    public class CarBookingAppDbContext : DbContext
    {
        public CarBookingAppDbContext(DbContextOptions<CarBookingAppDbContext> options) : base (options)
        {
            
        }
        public DbSet<Car> Cars { get; set; }
    }
}
    
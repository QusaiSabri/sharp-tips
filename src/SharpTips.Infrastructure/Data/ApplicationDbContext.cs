using Microsoft.EntityFrameworkCore;
using SharpTips.Domain.Entities;

namespace SharpTips.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<FlightBooking> FlightBookings { get; set; }
    }
}

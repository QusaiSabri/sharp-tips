using SharpTips.Application.Interfaces;
using SharpTips.Domain.Entities;
using SharpTips.Infrastructure.Data;

namespace SharpTips.Infrastructure.Repositories
{
    public class FlightBookingRepository : IFlightBookingRepository
    {
        private readonly ApplicationDbContext _context;

        public FlightBookingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<FlightBooking> AddFlightBookingAsync(FlightBooking booking)
        {
            _context.FlightBookings.Add(booking);
            await _context.SaveChangesAsync();
            return booking;
        }

        public async Task<IEnumerable<FlightBooking>> GetFlightBookingsAsync()
        {
            return _context.FlightBookings.ToList();
        }
    }
}

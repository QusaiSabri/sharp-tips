using SharpTips.Domain.Entities;

namespace SharpTips.Application.Interfaces
{
    public interface IFlightBookingRepository
    {
        Task<FlightBooking> AddFlightBookingAsync(FlightBooking booking);
        Task<IEnumerable<FlightBooking>> GetFlightBookingsAsync();
    }
}

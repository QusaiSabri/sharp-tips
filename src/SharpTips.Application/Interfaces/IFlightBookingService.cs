using SharpTips.Domain.Entities;

namespace SharpTips.Application.Interfaces
{
    public interface IFlightBookingService
    {
        Task<FlightBooking> CreateFlightBookingAsync(FlightBooking booking);
        Task DeleteFlightBookingAsync(int id);
        Task<IEnumerable<FlightBooking>> GetFlightBookingsAsync();
    }
}
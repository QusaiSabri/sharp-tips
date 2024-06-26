﻿using SharpTips.Domain.Entities;

namespace SharpTips.Application.Interfaces
{
    public interface IFlightBookingRepository
    {
        Task<FlightBooking> AddFlightBookingAsync(FlightBooking booking);
        Task DeleteFlightBookingAsync(int id);
        Task<IEnumerable<FlightBooking>> GetFlightBookingsAsync();
    }
}

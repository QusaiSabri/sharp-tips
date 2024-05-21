using NodaTime;
using SharpTips.Application.Interfaces;
using SharpTips.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTips.Application.Services
{
    public class FlightBookingService : IFlightBookingService
    {
        private readonly IFlightBookingRepository _repository;

        public FlightBookingService(IFlightBookingRepository repository)
        {
            _repository = repository;
        }

        public async Task<FlightBooking> CreateFlightBookingAsync(FlightBooking booking)
        {
            booking.DepartureTimeUTC = ConvertLocalToUtc(booking.DepartureTimeLocal, booking.TimeZoneID);
            return await _repository.AddFlightBookingAsync(booking);
        }

        public async Task<IEnumerable<FlightBooking>> GetFlightBookingsAsync()
        {
            var bookings = await _repository.GetFlightBookingsAsync();
            foreach (var booking in bookings)
            {
                booking.DepartureTimeUTC = ConvertLocalToUtc(booking.DepartureTimeLocal, booking.TimeZoneID);
            }
            return bookings;
        }


        private DateTime ConvertLocalToUtc(DateTime localDateTime, string timeZoneId)
        {
            var timeZone = DateTimeZoneProviders.Tzdb[timeZoneId];
            var localDateTimeInZone = LocalDateTime.FromDateTime(localDateTime);
            var zonedDbDateTime = localDateTimeInZone.InZoneLeniently(timeZone);
            return zonedDbDateTime.ToDateTimeUtc();
        }

        public async Task DeleteFlightBookingAsync(int id)
        {
            await _repository.DeleteFlightBookingAsync(id);
        }
    }
}

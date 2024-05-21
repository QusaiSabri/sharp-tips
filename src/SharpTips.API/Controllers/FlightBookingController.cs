using Microsoft.AspNetCore.Mvc;
using SharpTips.Application.Interfaces;
using SharpTips.Application.Services;
using SharpTips.Domain.Entities;

namespace SharpTips.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightBookingController : ControllerBase
    {
        private readonly IFlightBookingService _flightBookingService;

        public FlightBookingController(IFlightBookingService flightBookingService)
        {
            _flightBookingService = flightBookingService;
        }


        [HttpPost]
        public async Task<IActionResult> CreateBooking([FromBody] FlightBooking booking)
        {
            var result = await _flightBookingService.CreateFlightBookingAsync(booking);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _flightBookingService.GetFlightBookingsAsync();
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _flightBookingService.DeleteFlightBookingAsync(id);
            return Ok();
        }
    }
}

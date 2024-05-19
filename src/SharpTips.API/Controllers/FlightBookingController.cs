using Microsoft.AspNetCore.Mvc;
using SharpTips.Application.Interfaces;
using SharpTips.Domain.Entities;

namespace SharpTips.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightBookingController : ControllerBase
    {
        private readonly IFlightBookingRepository _repository;

        public FlightBookingController(IFlightBookingRepository repository)
        {
            _repository = repository;
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] FlightBooking booking)
        {
            var result = await _repository.AddFlightBookingAsync(booking);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _repository.GetFlightBookingsAsync();
            return Ok(result);
        }
    }
}

using FacuTheRock.Talks.Net.SystemClock.API.Models;
using FacuTheRock.Talks.Net.SystemClock.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace FacuTheRock.Talks.Net.SystemClock.API.Controllers
{
    [ApiController]
    [Route("birthdays")]
    public class BirthDayController : ControllerBase
    {
        private readonly BirthDayCalculator _birthDayCalculator;

        public BirthDayController(BirthDayCalculator birthDayCalculator)
        {
            _birthDayCalculator = birthDayCalculator;
        }

        [HttpGet("next")]
        public int CalculateNext([FromBody] BirthDayRequest request)
        {
            return _birthDayCalculator.CalculateNextBirthDayInDays(
                request.Month,
                request.Day);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vacation.API.Models.Dtos;
using Vacation.API.Repositories.InMemory;
using Vacation.API.Repositories.Repositories;

namespace Vacation.API.Controllers
{
    [Route("api/non-working-days")]
    [ApiController]
    public class TestFirstApiController : ControllerBase
    {
        // just for test, use service layer here and service should talk to repository.
        private readonly INonWorkingDaysRepository _nonWorkingDaysRepository;

        public TestFirstApiController(INonWorkingDaysRepository nonWorkingDaysRepository)
        {
            _nonWorkingDaysRepository = nonWorkingDaysRepository;
        }

        [HttpGet("/test")]
        public string GetTest()
        {
            return "Hi there";
        }

        [HttpGet("/{dateString}")]
        public async Task<DayStatusDTO> checkDateStatus(string dateString)
        {
            if (!DateOnly.TryParse(dateString, out var date))
            {
                throw new ArgumentException("invalid date format", nameof(dateString));
            }
            bool isWorkingDayValue = await _nonWorkingDaysRepository.IsWorkingDay(date);
            return new DayStatusDTO(dateString, isWorkingDayValue);
        }
    }
}
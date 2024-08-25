using Microsoft.AspNetCore.Mvc;
using Vacation.API.Models.Dtos;
using Vacation.API.Services.Interfaces;

namespace Vacation.API.Controllers
{
    [Route("api/non-working-days")]
    [ApiController]
    public class NonWorkingDaysController : ControllerBase
    {
        private readonly IWorkingDayService _workingDayService;

        public NonWorkingDaysController(IWorkingDayService workingDayService)
        {
            _workingDayService = workingDayService;
        }

        [HttpGet("check-date-status/{dateString}")]
        public async Task<DayStatusDTO> checkDateStatusAsync(string dateString)
        {
            bool isWorkingDayValue = await _workingDayService.IsWorkingDay(dateString);
            return new DayStatusDTO(dateString, isWorkingDayValue);
        }

        [HttpGet]
        public async Task<IEnumerable<DateOnly>> getAllNonWorkingDaysByYearAsync()
        {
            return await _workingDayService.GetAllNonWorkingDaysAsync();
        }

        [HttpGet("{year:int}")]
        public async Task<IEnumerable<DateOnly>> getAllNonWorkingDaysAsync(int year)
        {
            return await _workingDayService.GetNonWorkingDaysByYearAsync(year);
        }
    }
}
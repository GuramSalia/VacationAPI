using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Net;
using Vacation.API.Models;
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

        [HttpGet("status/{dateString}")]
        public async Task<ActionResult<APIResponse>> CheckDateStatusAsync(string dateString)
        {
            APIResponse response = new();

            try
            {
                if (!DateOnly.TryParse(dateString, out var date))
                {
                    response.StatusCode = HttpStatusCode.BadRequest;
                    response.IsSuccess = false;
                    response.ErrorMessages.Add($"invalid data format: {dateString}");
                    return response;
                }

                bool isWorkingDayValue = await _workingDayService.IsWorkingDay(date);
                response.StatusCode = HttpStatusCode.OK;
                response.Result = new DayStatusDTO(dateString, isWorkingDayValue);
                return response;
            }
            catch (Exception ex)
            {
                return GeneralErrorResponse(ex, response);
            }
        }

        [HttpGet]
        public async Task<ActionResult<APIResponse>> GetAllNonWorkingDaysByYearAsync()
        {
            APIResponse response = new();
            try
            {
                response.Result = await _workingDayService.GetAllNonWorkingDaysAsync();
                response.StatusCode = HttpStatusCode.OK;
                return response;
            }
            catch (Exception ex)
            {
                return GeneralErrorResponse(ex, response);
            }
        }

        [HttpGet("{year}")]
        public async Task<ActionResult<APIResponse>> GetAllNonWorkingDaysAsync(string year)
        {
            APIResponse response = new();
            try
            {
                if (!int.TryParse(year, out var intYear))
                {
                    response.StatusCode = HttpStatusCode.BadRequest;
                    response.IsSuccess = false;
                    response.ErrorMessages.Add($"invalid format for year: {year}");
                    return response;
                }
                response.Result = await _workingDayService.GetNonWorkingDaysByYearAsync(intYear);
                response.StatusCode = HttpStatusCode.OK;
                return response;
            }
            catch (Exception ex)
            {
                return GeneralErrorResponse(ex, response);
            }
        }

        private APIResponse GeneralErrorResponse(Exception exception, APIResponse response)
        {
            Type exceptionType = exception.GetType();
            string exceptionTypeName = exceptionType.Name;
            // maybe I don't want to show to the user the exception type. I could do it by adding name to ErrorMessage string.
            // maybe I should just log it when I have implemented a logger.

            response.StatusCode = HttpStatusCode.InternalServerError;
            response.IsSuccess = false;
            response.ErrorMessages.Add($"something went wrong: {exception.Message}");
            return response;
        }
    }
}
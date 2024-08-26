using Vacation.API.Repositories.Repositories;
using Vacation.API.Services.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Vacation.API.Services
{
    public class WorkingDayService : IWorkingDayService
    {
        private readonly INonWorkingDaysRepository _nonWorkingDaysRepository;

        public WorkingDayService(INonWorkingDaysRepository nonWorkingDaysRepository)
        {
            _nonWorkingDaysRepository = nonWorkingDaysRepository;
        }

        public async Task<IEnumerable<DateOnly>> GetAllNonWorkingDaysAsync()
        {
            return await _nonWorkingDaysRepository.GetAllNonWorkingDaysAsync();
        }

        public async Task<IEnumerable<DateOnly>> GetNonWorkingDaysByYearAsync(int year)
        {
            return await _nonWorkingDaysRepository.GetNonWorkingDaysByYearAsync(year);
        }

        public async Task<bool> IsNonWorkingDay(DateOnly date)
        {
            return await _nonWorkingDaysRepository.IsNonWorkingDay(date);
        }

        public async Task<bool> IsWorkingDay(DateOnly date)
        {
            return await _nonWorkingDaysRepository.IsWorkingDay(date);
        }
    }
}
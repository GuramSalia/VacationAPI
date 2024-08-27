using Vacation.API.Data.PreGenerated;
using Vacation.API.Repositories.Repositories;

namespace Vacation.API.Repositories.InMemory
{
    public class InMemoryNonWorkingDaysRepository : INonWorkingDaysRepository
    {
        private readonly HashSet<DateOnly> _nonWorkingDays = new();

        public InMemoryNonWorkingDaysRepository()
        {
            // add non working days to _nonWorkingDays
            foreach (string day in NonWorkingDaysDbMock._all)
            {
                _nonWorkingDays.Add(DateOnly.Parse(day));
            }
        }

        public Task<IEnumerable<DateOnly>> GetAllNonWorkingDaysAsync()
        {
            return Task.FromResult(_nonWorkingDays.AsEnumerable());
        }

        public Task<IEnumerable<DateOnly>> GetNonWorkingDaysByYearAsync(int year)
        {
            var result = _nonWorkingDays.Where(date => date.Year == year);
            return Task.FromResult(result);
        }

        public Task<bool> IsNonWorkingDay(DateOnly date)
        {
            return Task.FromResult(_nonWorkingDays.Contains(date));
        }

        public Task<bool> IsWorkingDay(DateOnly date)
        {
            return Task.FromResult(!_nonWorkingDays.Contains(date));
        }
    }
}
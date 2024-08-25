using Vacation.API.Repositories.Repositories;

namespace Vacation.API.Repositories.InMemory
{
    public class InMemoryNonWorkingDaysRepository : INonWorkingDaysRepository
    {
        private readonly HashSet<DateOnly> _nonWorkingDays = new();

        public InMemoryNonWorkingDaysRepository()
        {
            // add non working days to _nonWorkingDays
            foreach (string day in ListOfNonWorkingDays._all)
            {
                _nonWorkingDays.Add(DateOnly.Parse(day));
            }
        }

        public Task<IEnumerable<DateOnly>> GetAllNonWorkingDaysAsync()
        {
            return Task.FromResult(_nonWorkingDays.AsEnumerable());
        }

        public Task<bool> IsNonWorkingDay(DateOnly day)
        {
            return Task.FromResult(_nonWorkingDays.Contains(day));
        }

        public Task<bool> IsWorkingDay(DateOnly day)
        {
            return Task.FromResult(!_nonWorkingDays.Contains(day));
        }
    }
}
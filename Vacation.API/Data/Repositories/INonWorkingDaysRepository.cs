namespace Vacation.API.Data.Repositories
{
    public interface INonWorkingDaysRepository
    {
        Task<IEnumerable<DateOnly>> GetAllNonWorkingDaysAsync();

        Task<bool> IsNonWorkingDay(DateOnly day);

        Task<bool> IsWorkingDay(DateOnly day);
    }
}
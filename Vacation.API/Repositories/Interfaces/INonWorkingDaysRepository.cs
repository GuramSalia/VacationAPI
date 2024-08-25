namespace Vacation.API.Repositories.Repositories
{
    public interface INonWorkingDaysRepository
    {
        Task<IEnumerable<DateOnly>> GetAllNonWorkingDaysAsync();

        Task<IEnumerable<DateOnly>> GetNonWorkingDaysByYearAsync(int year);

        Task<bool> IsNonWorkingDay(DateOnly day);

        Task<bool> IsWorkingDay(DateOnly day);
    }
}
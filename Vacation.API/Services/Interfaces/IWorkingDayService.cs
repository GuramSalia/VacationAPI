namespace Vacation.API.Services.Interfaces
{
    public interface IWorkingDayService
    {
        Task<IEnumerable<DateOnly>> GetAllNonWorkingDaysAsync();

        Task<IEnumerable<DateOnly>> GetNonWorkingDaysByYearAsync(int year);

        Task<bool> IsNonWorkingDay(DateOnly date);

        Task<bool> IsWorkingDay(DateOnly date);
    }
}
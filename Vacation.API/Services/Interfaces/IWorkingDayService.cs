namespace Vacation.API.Services.Interfaces
{
    public interface IWorkingDayService
    {
        Task<IEnumerable<DateOnly>> GetAllNonWorkingDaysAsync();

        Task<IEnumerable<DateOnly>> GetNonWorkingDaysByYearAsync(int year);

        Task<bool> IsNonWorkingDay(string dateString);

        Task<bool> IsWorkingDay(string dateString);
    }
}
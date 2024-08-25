namespace Vacation.API.Models.Dtos
{
    public class DayStatusDTO
    {
        public DateOnly Date { get; }

        public bool IsWorkingDay { get; }

        public DayStatusDTO(DateOnly date, bool isNonWorkingDay)
        {
            Date = date;
            IsWorkingDay = isNonWorkingDay;
        }

        public DayStatusDTO(string date, bool isWorkingDay)
        {
            if (!DateOnly.TryParse(date, out DateOnly parsedDate))
            {
                throw new ArgumentException("invalid date format", nameof(date));
            }
            Date = parsedDate;
            IsWorkingDay = isWorkingDay;
        }
    }
}
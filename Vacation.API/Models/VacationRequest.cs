using Vacation.API.Models.Enums;

namespace Vacation.API.Models
{
    public class VacationRequest
    {
        public int Id { get; set; }
        public Employee Employee { get; set; } = new Employee();
        public DateOnly RequestDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public DateOnly VacationStartDate { get; set; }
        public DateOnly VacationEndDate { get; set; }
        public DateOnly NormalizedStartDate { get; set; }
        public DateOnly NormalizedEndDate { get; set; }
        public LeaveType LeaveType { get; set; }
        public string? Description { get; set; }
    }
}
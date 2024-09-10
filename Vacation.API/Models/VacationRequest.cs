using Vacation.API.Models.Enums;

namespace Vacation.API.Models
{
    public class VacationRequest
    {
        public int VacationRequestId { get; set; }
        public Employee Employee { get; set; } = new Employee();
        public DateOnly RequestDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public DateOnly VacationStartDate { get; set; }
        public DateOnly VacationEndDate { get; set; }
        public DateOnly NormalizedStartDate { get; set; }
        public DateOnly NormalizedEndDate { get; set; }
        public LeaveType LeaveType { get; set; }
        public string? Description { get; set; }
        public ApprovalFlow ApprovalWorkFlow { get; set; } = new ApprovalFlow();
        public ApprovalStep? CurrentStep { get; set; }
        public bool IsWithdrawn { get; set; } = false;
    }
}
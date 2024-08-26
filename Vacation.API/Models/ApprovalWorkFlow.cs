using Vacation.API.Models.Enums;

namespace Vacation.API.Models
{
    public class ApprovalWorkFlow
    {
        public int WorkFlowId { get; set; }
        public string WorkFlowName { get; set; } = string.Empty;
        public List<LeaveType> VacationTypes { get; set; } = new List<LeaveType>();
        public OrganizationalUnit OrganizationalUnit { get; set; } = new OrganizationalUnit();
        public int Sequence { get; set; }
        public DateOnly EffectiveStartDate { get; set; }
        public DateOnly EffectiveEndDate { get; set; }
        public string? ApprovalConditions { get; set; }
    }
}

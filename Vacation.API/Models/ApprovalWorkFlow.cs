using Vacation.API.Models.Enums;

namespace Vacation.API.Models
{
    public class ApprovalWorkFlow
    {
        public int WorkFlowId { get; set; }
        public string WorkFlowName { get; set; } = string.Empty;
        public List<LeaveType> VacationTypes { get; set; } = new List<LeaveType>();
        public List<OrganizationalUnit> OrganizationalUnit { get; set; } = new List<OrganizationalUnit>();
        public List<Position> Positions { get; set; } = new List<Position>();
        public DateOnly EffectiveStartDate { get; set; }
        public DateOnly EffectiveEndDate { get; set; }
        public string? ApprovalConditions { get; set; }
        public ICollection<VacationRequest> VacationRequests { get; set; } = new List<VacationRequest>();
    }
}
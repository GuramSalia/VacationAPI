using Vacation.API.Models.Enums;

namespace Vacation.API.Models.JoinEntities
{
    public class ApprovalWorkFlowLeaveType
    {
        public int WorkFlowId { get; set; }
        public ApprovalFlow WorkFlow { get; set; } = new ApprovalFlow();

        public LeaveType LeaveType { get; set; } = new LeaveType();
    }
}
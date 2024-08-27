using Vacation.API.Models.Enums;

namespace Vacation.API.Models.JoinEntities
{
    public class ApprovalWorkFlowLeaveType
    {
        public int WorkFlowId { get; set; }
        public ApprovalWorkFlow WorkFlow { get; set; } = new ApprovalWorkFlow();

        public LeaveType LeaveType { get; set; } = new LeaveType();
    }
}
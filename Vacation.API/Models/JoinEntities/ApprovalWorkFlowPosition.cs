namespace Vacation.API.Models.JoinEntities
{
    public class ApprovalWorkFlowPosition
    {
        public int WorkFlowId { get; set; }
        public ApprovalWorkFlow WorkFlow { get; set; } = new ApprovalWorkFlow();
        public int PositionId { get; set; }
        public Position Position { get; set; } = new Position();
    }
}
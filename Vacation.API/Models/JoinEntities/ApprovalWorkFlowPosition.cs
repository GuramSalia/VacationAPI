namespace Vacation.API.Models.JoinEntities
{
    public class ApprovalWorkFlowPosition
    {
        public int WorkFlowId { get; set; }
        public ApprovalFlow WorkFlow { get; set; } = new ApprovalFlow();
        public int PositionId { get; set; }
        public Position Position { get; set; } = new Position();
    }
}
namespace Vacation.API.Models
{
    public class ApprovalWorkFlowStep
    {
        public int ApprovalWorkFlowStepId { get; set; }
        public ApprovalWorkFlow ApprovalWorkFlow { get; set; } = new ApprovalWorkFlow();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ApprovalLevel { get; set; } = 1;
        public Employee Approver { get; set; } = new Employee();
        public bool IsFinalApprovalLevel { get; set; } = false; // I should handle when it is false but there is no next level
    }
}
namespace Vacation.API.Models
{
    public class ApprovalStep
    {
        public int Id { get; set; }
        public ApprovalFlow ApprovalFlow { get; set; } = new ApprovalFlow();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ApprovalLevel { get; set; } = 1;
        public Employee Approver { get; set; } = new Employee(); // I could have a separate class which combines list of employees and a list of roles which can approve 
        
        public bool IsFinalApprovalLevel { get; set; } = false; // I should handle when it is false but there is no next level
    }
}
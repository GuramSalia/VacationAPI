using Vacation.API.Models;

namespace Vacation.API.Data.PreGenerated
{
    internal class ApprovalWorkFlowStepsDbMock
    {
        internal static List<ApprovalWorkFlowStep> _approvalWorkFlowSteps =
        [
            new ApprovalWorkFlowStep
            {
                ApprovalWorkFlowStepId = 1,
                ApprovalWorkFlow = ApprovalWorkFlowsDbMock._approvalWorkFlows.First(w => w.WorkFlowId == 3),
                Name = "Team Lead Approval",
                Description = "Initial approval step by Team Lead.",
                ApprovalLevel = 1,
                Approver = new Employee
                {
                    EmployeeId = 16, // Team Lead
                    Name = "Eva",
                    Surname = "Green"
                },
                IsFinalApprovalLevel = false
            },
            new ApprovalWorkFlowStep
            {
                ApprovalWorkFlowStepId = 2,
                ApprovalWorkFlow = ApprovalWorkFlowsDbMock._approvalWorkFlows.First(w => w.WorkFlowId == 3),
                Name = "Manager Approval",
                Description = "Final approval step by Manager.",
                ApprovalLevel = 2,
                Approver = new Employee
                {
                    EmployeeId = 17, // Manager
                    Name = "John",
                    Surname = "ITHead"
                },
                IsFinalApprovalLevel = true
            },
            new ApprovalWorkFlowStep
            {
                ApprovalWorkFlowStepId = 3,
                ApprovalWorkFlow = ApprovalWorkFlowsDbMock._approvalWorkFlows.First(w => w.WorkFlowId == 1),
                Name = "HR Department Approval",
                Description = "Approval required from HR Department.",
                ApprovalLevel = 1,
                Approver = new Employee
                {
                    EmployeeId = 18, // HR Head
                    Name = "James",
                    Surname = "HRHead"
                },
                IsFinalApprovalLevel = true
            },
            new ApprovalWorkFlowStep
            {
                ApprovalWorkFlowStepId = 4,
                ApprovalWorkFlow = ApprovalWorkFlowsDbMock._approvalWorkFlows.First(w => w.WorkFlowId == 2),
                Name = "IT Department Approval",
                Description = "Approval required from IT Department.",
                ApprovalLevel = 1,
                Approver = new Employee
                {
                    EmployeeId = 17, // IT Head
                    Name = "John",
                    Surname = "ITHead"
                },
                IsFinalApprovalLevel = true
            }
        ];
    }
}
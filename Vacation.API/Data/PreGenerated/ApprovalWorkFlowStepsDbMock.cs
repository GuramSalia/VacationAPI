using Vacation.API.Models;

namespace Vacation.API.Data.PreGenerated
{
    internal class ApprovalWorkFlowStepsDbMock
    {
        internal static List<ApprovalStep> _approvalWorkFlowSteps =
        [
            new ApprovalStep
            {
                Id = 1,
                ApprovalFlow = ApprovalWorkFlowsDbMock._approvalWorkFlows.First(w => w.Id == 3),
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
            new ApprovalStep
            {
                Id = 2,
                ApprovalFlow = ApprovalWorkFlowsDbMock._approvalWorkFlows.First(w => w.Id == 3),
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
            new ApprovalStep
            {
                Id = 3,
                ApprovalFlow = ApprovalWorkFlowsDbMock._approvalWorkFlows.First(w => w.Id == 1),
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
            new ApprovalStep
            {
                Id = 4,
                ApprovalFlow = ApprovalWorkFlowsDbMock._approvalWorkFlows.First(w => w.Id == 2),
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
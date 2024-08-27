using Vacation.API.Models;
using Vacation.API.Models.JoinEntities;

namespace Vacation.API.Data.PreGenerated.JoinEntities
{
    internal class ApprovalWorkFlowPositionDbMock
    {
        internal static List<ApprovalWorkFlowPosition> _approvalWorkFlowPositions =
        [
            // Example: Linking Team Lead Position (PositionId = 9) to Team Lead Approval Workflow (WorkFlowId = 3)
            new ApprovalWorkFlowPosition
            {
                WorkFlowId = 3,     // "Approval by Position Team Lead"
                PositionId = 9      // "Team Leader"
            },
            // Example: Linking Manager Position (PositionId = 8) to Manager Approval Workflow (WorkFlowId = 4)
            new ApprovalWorkFlowPosition
            {
                WorkFlowId = 4,     // "Approval by Position Manager"
                PositionId = 8      // "Head of IT Department"
            },
            new ApprovalWorkFlowPosition
            {
                WorkFlowId = 4,     // "Approval by Position Manager"
                PositionId = 10     // "Head of HR"
            }
        ];
    }
}
using Vacation.API.Models.JoinEntities;

namespace Vacation.API.Data.PreGenerated.JoinEntities
{
    internal class ApprovalWorkFlowOrganizationalUnitDbMock
    {
        internal static List<ApprovalWorkFlowOrganizationalUnit> _approvalWorkFlowOrganizationalUnits =
        [
            new ApprovalWorkFlowOrganizationalUnit
            {
                WorkFlowId = 1,             // "Standard Approval for HR Department"
                OrganizationalUnitId = 6    // "HR Department"
            },
            new ApprovalWorkFlowOrganizationalUnit
            {
                WorkFlowId = 3,             // "Approval by Position Team Lead"
                OrganizationalUnitId = 2    // "Development Team"
            },
            // "Standard Approval for IT Department" - Id = 2
            new ApprovalWorkFlowOrganizationalUnit
            {
                WorkFlowId = 2,             // "Standard Approval for IT Department"
                OrganizationalUnitId = 1    // "IT Department"
            },
            new ApprovalWorkFlowOrganizationalUnit
            {
                WorkFlowId = 2,             // "Standard Approval for IT Department"
                OrganizationalUnitId = 3    // "QA Team"
            },
            new ApprovalWorkFlowOrganizationalUnit
            {
                WorkFlowId = 2,             // "Standard Approval for IT Department"
                OrganizationalUnitId =  4   // "Frontend SubTeam"
            },
            new ApprovalWorkFlowOrganizationalUnit
            {
                WorkFlowId = 2,             // "Standard Approval for IT Department"
                OrganizationalUnitId =  5   // "Backend SubTeam"
            }
        ];
    }
}
using Vacation.API.Models;

namespace Vacation.API.Data.PreGenerated
{
    internal class ApprovalWorkFlowsDbMock
    {
        internal static List<ApprovalFlow> _approvalWorkFlows =
        [
            new ApprovalFlow
            {
                Id = 1,
                Name = "Standard Approval for HR Department",
                EffectiveStartDate = DateOnly.FromDateTime(DateTime.Now),
                EffectiveEndDate = DateOnly.FromDateTime(DateTime.Now.AddYears(1)),
                ApprovalConditions = "Standard HR approval process."
            },
            new ApprovalFlow
            {
                Id = 2,
                Name = "Standard Approval for IT Department",
                EffectiveStartDate = DateOnly.FromDateTime(DateTime.Now),
                EffectiveEndDate = DateOnly.FromDateTime(DateTime.Now.AddYears(1)),
                ApprovalConditions = "Standard IT approval process."
            },
            new ApprovalFlow
            {
                Id = 3,
                Name = "Approval by Position Team Lead",
                EffectiveStartDate = DateOnly.FromDateTime(DateTime.Now),
                EffectiveEndDate = DateOnly.FromDateTime(DateTime.Now.AddYears(1)),
                ApprovalConditions = "Approval required from the Team Lead."
            },
            new ApprovalFlow
            {
                Id = 4,
                Name = "Approval by Position Manager",
                EffectiveStartDate = DateOnly.FromDateTime(DateTime.Now),
                EffectiveEndDate = DateOnly.FromDateTime(DateTime.Now.AddYears(1)),
                ApprovalConditions = "Approval required from the Manager."
            }
        ];
    }
}
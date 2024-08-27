using Vacation.API.Models;

namespace Vacation.API.Data.PreGenerated
{
    internal class ApprovalWorkFlowsDbMock
    {
        internal static List<ApprovalWorkFlow> _approvalWorkFlows =
        [
            new ApprovalWorkFlow
            {
                WorkFlowId = 1,
                WorkFlowName = "Standard Approval for HR Department",
                EffectiveStartDate = DateOnly.FromDateTime(DateTime.Now),
                EffectiveEndDate = DateOnly.FromDateTime(DateTime.Now.AddYears(1)),
                ApprovalConditions = "Standard HR approval process."
            },
            new ApprovalWorkFlow
            {
                WorkFlowId = 2,
                WorkFlowName = "Standard Approval for IT Department",
                EffectiveStartDate = DateOnly.FromDateTime(DateTime.Now),
                EffectiveEndDate = DateOnly.FromDateTime(DateTime.Now.AddYears(1)),
                ApprovalConditions = "Standard IT approval process."
            },
            new ApprovalWorkFlow
            {
                WorkFlowId = 3,
                WorkFlowName = "Approval by Position Team Lead",
                EffectiveStartDate = DateOnly.FromDateTime(DateTime.Now),
                EffectiveEndDate = DateOnly.FromDateTime(DateTime.Now.AddYears(1)),
                ApprovalConditions = "Approval required from the Team Lead."
            },
            new ApprovalWorkFlow
            {
                WorkFlowId = 4,
                WorkFlowName = "Approval by Position Manager",
                EffectiveStartDate = DateOnly.FromDateTime(DateTime.Now),
                EffectiveEndDate = DateOnly.FromDateTime(DateTime.Now.AddYears(1)),
                ApprovalConditions = "Approval required from the Manager."
            }
        ];
    }
}
using Vacation.API.Models.Enums;

namespace Vacation.API.Models
{
    public class ApprovalWorkFlow
    {
        public int WorkFlowId { get; set; }
        public string WorkFlowName { get; set; } = string.Empty;
        public DateOnly EffectiveStartDate { get; set; }
        public DateOnly EffectiveEndDate { get; set; }
        public string? ApprovalConditions { get; set; }
    }
}
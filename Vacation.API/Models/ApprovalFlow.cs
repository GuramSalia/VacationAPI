using Vacation.API.Models.Enums;

namespace Vacation.API.Models
{
    public class ApprovalFlow
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateOnly EffectiveStartDate { get; set; }
        public DateOnly? EffectiveEndDate { get; set; }
        public string? ApprovalConditions { get; set; }
    }
}
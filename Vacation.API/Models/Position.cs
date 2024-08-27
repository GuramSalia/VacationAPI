namespace Vacation.API.Models
{
    public class Position
    {
        public int PositionId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateOnly CreatedAt { get; set; }
        public DateOnly UpdatedAt { get; set; }
        public bool HasPositionBasedVacationApprovalFlow { get; set; } = false;
    }
}
using Vacation.API.Models;

namespace Vacation.API.Data.PreGenerated
{
    internal class PositionsDbMock
    {
        internal static List<Position> _positions =
        [
            new Position
            {
                PositionId = 1,
                Name = "Software Engineer",
                Description = "Responsible for developing and maintaining software applications.",
                CreatedAt = DateOnly.FromDateTime(DateTime.Now.AddMonths(-6)),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now),
                HasPositionBasedVacationApprovalFlow = false
            },
            new Position
            {
                PositionId = 2,
                Name = "Project Manager",
                Description = "Oversees project planning, scheduling, and execution.",
                CreatedAt = DateOnly.FromDateTime(DateTime.Now.AddYears(-1)),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now),
                HasPositionBasedVacationApprovalFlow = false
            },
            new Position
            {
                PositionId = 3,
                Name = "HR Specialist",
                Description = "Handles employee relations, benefits, and recruitment.",
                CreatedAt = DateOnly.FromDateTime(DateTime.Now.AddYears(-2)),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now),
                HasPositionBasedVacationApprovalFlow = false
            },
            new Position
            {
                PositionId = 5,
                Name = "DevOps Engineer",
                Description = "Manages infrastructure and deployment pipelines.",
                CreatedAt = DateOnly.FromDateTime(DateTime.Now.AddMonths(-9)),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now),
                HasPositionBasedVacationApprovalFlow = false
            },
            new Position
            {
                PositionId = 6,
                Name = "Business Analyst",
                Description = "Analyzes business needs and develops solutions.",
                CreatedAt = DateOnly.FromDateTime(DateTime.Now.AddMonths(-10)),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now),
                HasPositionBasedVacationApprovalFlow = false
            },
            new Position
            {
                PositionId = 7,
                Name = "UX/UI Designer",
                Description = "Designs user interfaces and user experiences.",
                CreatedAt = DateOnly.FromDateTime(DateTime.Now.AddMonths(-7)),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now),
                HasPositionBasedVacationApprovalFlow = false
            },
            new Position
            {
                PositionId = 8,
                Name = "Head of IT Department",
                Description = "Leads the IT department and oversees all technology-related operations.",
                CreatedAt = DateOnly.FromDateTime(DateTime.Now.AddYears(-4)),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now),
                HasPositionBasedVacationApprovalFlow = true
            },
            new Position
            {
                PositionId = 9,
                Name = "Team Leader",
                Description = "Leads a team of software developers and ensures project delivery.",
                CreatedAt = DateOnly.FromDateTime(DateTime.Now.AddMonths(-8)),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now),
                HasPositionBasedVacationApprovalFlow = true
            },
            new Position
            {
                PositionId = 10,
                Name = "Head of HR",
                Description = "Manages the HR department and oversees all human resources functions.",
                CreatedAt = DateOnly.FromDateTime(DateTime.Now.AddYears(-5)),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now),
                HasPositionBasedVacationApprovalFlow = true
            }
        ];
    }
}
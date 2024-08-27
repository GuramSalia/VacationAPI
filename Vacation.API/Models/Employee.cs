using Vacation.API.Models.JoinEntities;

namespace Vacation.API.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string PersonalId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public OrganizationalUnit OrganizationalUnit { get; set; } = new OrganizationalUnit();
        public Position Position { get; set; } = new Position();
        public DateOnly? ProbationPeriodExpirationDate { get; set; }
        public DateOnly EmploymentStartDate { get; set; }
        public bool IsCurrentEmployee { get; set; }
        public DateOnly? CompanyLeaveDate { get; set; }
        public DateOnly CreatedAt { get; set; }
        public DateOnly UpdatedAt { get; set; }
        public ICollection<EmployeeRole> EmployeeRoles { get; set; } = new List<EmployeeRole>();
    }
}
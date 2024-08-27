namespace Vacation.API.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public ICollection<EmployeeRole> EmployeesWithRole { get; set; } = new List<EmployeeRole>();
    }
}
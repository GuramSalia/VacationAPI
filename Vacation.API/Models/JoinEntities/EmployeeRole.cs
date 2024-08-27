namespace Vacation.API.Models.JoinEntities
{
    public class EmployeeRole
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = new Employee();
        public int RoleId { get; set; }
        public Role Role { get; set; } = new Role();
        public DateTime AssignedDate { get; set; }
    }
}
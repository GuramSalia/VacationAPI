using System.ComponentModel.DataAnnotations;

namespace Vacation.API.Models
{
    public class Role
    {
        public int RoleId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }
        public ICollection<Employee> EmployeeRoles { get; set; } = new List<Employee>();
    }
}
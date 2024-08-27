using Vacation.API.Models;

namespace Vacation.API.Data.PreGenerated
{
    internal class RolesDbMock
    {
        internal static List<Role> _roles =
        [
            new Role
            {
                RoleId = 1,
                Name = "HR Director",
                Description = "Responsible for overseeing all HR functions and has the authority to approve vacations for all employees across the organization."
            },
            new Role
            {
                RoleId = 2,
                Name = "IT Department Head",
                Description = "Manages the IT department and has the authority to approve vacations for employees within the IT department."
            },
            new Role
            {
                RoleId = 3,
                Name = "Team Lead",
                Description = "Leads a specific team within the organization and has the authority to approve vacations for team members under their supervision."
            }
        ];
    }
}
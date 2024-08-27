using Vacation.API.Models.JoinEntities;

namespace Vacation.API.Data.PreGenerated.JoinEntities
{
    internal class EmployeeRoleEntriesDbMock
    {
        internal static List<EmployeeRole> _employeeRoles =
        [
            new EmployeeRole
            {
                EmployeeId = 16, // Eva Green
                RoleId = 3, // Team Lead
                AssignedDate = DateTime.Now
            },
            new EmployeeRole
            {
                EmployeeId = 17, // John ITHead
                RoleId = 2, // IT Department Head
                AssignedDate = DateTime.Now
            },
            new EmployeeRole
            {
                EmployeeId = 18, // James HRHead
                RoleId = 1, // HR Director
                AssignedDate = DateTime.Now
            }
        ];
    }
}
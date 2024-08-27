using Vacation.API.Models;

namespace Vacation.API.Data.PreGenerated
{
    internal class EmployeesDbMock
    {
        internal static List<Employee> _employees =
        [
            // Employees for IT Department
            new Employee
            {
                EmployeeId = 1,
                PersonalId = "01010000001",
                Name = "Alice",
                Surname = "Johnson",
                OrganizationalUnit = OrganizationalUnitsDbMock._organizationalUnits.First(u => u.UnitId == 1), // IT Department
                Position = PositionsDbMock._positions.First(p => p.PositionId == 1), // Software Engineer
                EmploymentStartDate = DateOnly.FromDateTime(DateTime.Now.AddYears(-2)),
                IsCurrentEmployee = true,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now)
            },
            new Employee
            {
                EmployeeId = 2,
                PersonalId = "01010000002",
                Name = "Bob",
                Surname = "Smith",
                OrganizationalUnit = OrganizationalUnitsDbMock._organizationalUnits.First(u => u.UnitId == 1), // IT Department
                Position = PositionsDbMock._positions.First(p => p.PositionId == 2), // Project Manager
                EmploymentStartDate = DateOnly.FromDateTime(DateTime.Now.AddYears(-1)),
                IsCurrentEmployee = true,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now)
            },
            new Employee
            {
                EmployeeId = 3,
                PersonalId = "01010000003",
                Name = "Charlie",
                Surname = "Brown",
                OrganizationalUnit = OrganizationalUnitsDbMock._organizationalUnits.First(u => u.UnitId == 6), // HR Department
                Position = PositionsDbMock._positions.First(p => p.PositionId == 3), // HR Specialist
                EmploymentStartDate = DateOnly.FromDateTime(DateTime.Now.AddYears(-3)),
                IsCurrentEmployee = true,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now)
            },

            // Employees for Development Team
            new Employee
            {
                EmployeeId = 4,
                PersonalId = "01010000004",
                Name = "David",
                Surname = "Wilson",
                OrganizationalUnit = OrganizationalUnitsDbMock._organizationalUnits.First(u => u.UnitId == 2), // Development Team
                Position = PositionsDbMock._positions.First(p => p.PositionId == 4), // DevOps Engineer
                EmploymentStartDate = DateOnly.FromDateTime(DateTime.Now.AddYears(-1)),
                IsCurrentEmployee = true,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now)
            },
            new Employee
            {
                EmployeeId = 5,
                PersonalId = "01010000005",
                Name = "Eve",
                Surname = "Davis",
                OrganizationalUnit = OrganizationalUnitsDbMock._organizationalUnits.First(u => u.UnitId == 2), // Development Team
                Position = PositionsDbMock._positions.First(p => p.PositionId == 5), // Business Analyst
                EmploymentStartDate = DateOnly.FromDateTime(DateTime.Now.AddMonths(-8)),
                IsCurrentEmployee = true,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now)
            },
            new Employee
            {
                EmployeeId = 6,
                PersonalId = "01010000006",
                Name = "Frank",
                Surname = "Martinez",
                OrganizationalUnit = OrganizationalUnitsDbMock._organizationalUnits.First(u => u.UnitId == 2), // Development Team
                Position = PositionsDbMock._positions.First(p => p.PositionId == 6), // Business Analyst
                EmploymentStartDate = DateOnly.FromDateTime(DateTime.Now.AddYears(-2)),
                IsCurrentEmployee = true,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now)
            },

            // Employees for QA Team
            new Employee
            {
                EmployeeId = 7,
                PersonalId = "01010000007",
                Name = "Grace",
                Surname = "Taylor",
                OrganizationalUnit = OrganizationalUnitsDbMock._organizationalUnits.First(u => u.UnitId == 3), // QA Team
                Position = PositionsDbMock._positions.First(p => p.PositionId == 7), // UX/UI Designer
                EmploymentStartDate = DateOnly.FromDateTime(DateTime.Now.AddYears(-1)),
                IsCurrentEmployee = true,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now)
            },
            new Employee
            {
                EmployeeId = 8,
                PersonalId = "01010000008",
                Name = "Hank",
                Surname = "Anderson",
                OrganizationalUnit = OrganizationalUnitsDbMock._organizationalUnits.First(u => u.UnitId == 3), // QA Team
                Position = PositionsDbMock._positions.First(p => p.PositionId == 4), // DevOps Engineer
                EmploymentStartDate = DateOnly.FromDateTime(DateTime.Now.AddMonths(-10)),
                IsCurrentEmployee = true,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now)
            },
            new Employee
            {
                EmployeeId = 9,
                PersonalId = "01010000009",
                Name = "Ivy",
                Surname = "Moore",
                OrganizationalUnit = OrganizationalUnitsDbMock._organizationalUnits.First(u => u.UnitId == 2), // Development Team
                Position = PositionsDbMock._positions.First(p => p.PositionId == 1), // Software Engineer
                EmploymentStartDate = DateOnly.FromDateTime(DateTime.Now.AddMonths(-12)),
                IsCurrentEmployee = true,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now)
            },

            // Employees for Frontend SubTeam
            new Employee
            {
                EmployeeId = 10,
                PersonalId = "01010000010",
                Name = "George",
                Surname = "Lee",
                OrganizationalUnit = OrganizationalUnitsDbMock._organizationalUnits.First(u => u.UnitId == 2), // Development Team
                Position = PositionsDbMock._positions.First(p => p.PositionId == 1), // Software Engineer
                EmploymentStartDate = DateOnly.FromDateTime(DateTime.Now.AddYears(-1)),
                IsCurrentEmployee = true,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now)
            },
            new Employee
            {
                EmployeeId = 11,
                PersonalId = "01010000011",
                Name = "Katherine",
                Surname = "Wright",
                OrganizationalUnit = OrganizationalUnitsDbMock._organizationalUnits.First(u => u.UnitId == 4), // Frontend SubTeam
                Position = PositionsDbMock._positions.First(p => p.PositionId == 2), // Project Manager
                EmploymentStartDate = DateOnly.FromDateTime(DateTime.Now.AddYears(-2)),
                IsCurrentEmployee = true,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now)
            },
            new Employee
            {
                EmployeeId = 12,
                PersonalId = "01010000012",
                Name = "Liam",
                Surname = "Harris",
                OrganizationalUnit = OrganizationalUnitsDbMock._organizationalUnits.First(u => u.UnitId == 4), // Frontend SubTeam
                Position = PositionsDbMock._positions.First(p => p.PositionId == 1), // Software Engineer
                EmploymentStartDate = DateOnly.FromDateTime(DateTime.Now.AddYears(-1)),
                IsCurrentEmployee = true,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now)
            },

            // Employees for Backend SubTeam
            new Employee
            {
                EmployeeId = 13,
                PersonalId = "01010000013",
                Name = "Mia",
                Surname = "Scott",
                OrganizationalUnit = OrganizationalUnitsDbMock._organizationalUnits.First(u => u.UnitId == 5), // Backend SubTeam
                Position = PositionsDbMock._positions.First(p => p.PositionId == 6), // Business Analyst
                EmploymentStartDate = DateOnly.FromDateTime(DateTime.Now.AddYears(-1)),
                IsCurrentEmployee = true,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now)
            },
            new Employee
            {
                EmployeeId = 14,
                PersonalId = "01010000014",
                Name = "Nora",
                Surname = "Young",
                OrganizationalUnit = OrganizationalUnitsDbMock._organizationalUnits.First(u => u.UnitId == 5), // Backend SubTeam
                Position = PositionsDbMock._positions.First(p => p.PositionId == 7), // UX/UI Designer
                EmploymentStartDate = DateOnly.FromDateTime(DateTime.Now.AddMonths(-6)),
                IsCurrentEmployee = true,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now)
            },
            new Employee
            {
                EmployeeId = 15,
                PersonalId = "01010000015",
                Name = "Oliver",
                Surname = "King",
                OrganizationalUnit = OrganizationalUnitsDbMock._organizationalUnits.First(u => u.UnitId == 5), // Backend SubTeam
                Position = PositionsDbMock._positions.First(p => p.PositionId == 4), // DevOps Engineer
                EmploymentStartDate = DateOnly.FromDateTime(DateTime.Now.AddMonths(-3)),
                IsCurrentEmployee = true,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now)
            },
            new Employee
            {
                EmployeeId = 16,
                PersonalId = "01010000016",
                Name = "Eva",
                Surname = "Green",
                OrganizationalUnit = OrganizationalUnitsDbMock._organizationalUnits.First(u => u.UnitId == 2), // Development Team
                Position = PositionsDbMock._positions.First(p => p.PositionId == 9), // Team Leader
                EmploymentStartDate = DateOnly.FromDateTime(DateTime.Now.AddYears(-3)),
                IsCurrentEmployee = true,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now)
            },
                        new Employee
            {
                EmployeeId = 17,
                PersonalId = "01010000017",
                Name = "John",
                Surname = "ITHead",
                OrganizationalUnit = OrganizationalUnitsDbMock._organizationalUnits.First(u => u.UnitId == 1), // IT Department
                Position = PositionsDbMock._positions.First(p => p.PositionId == 8), // Head of IT Department
                EmploymentStartDate = DateOnly.FromDateTime(DateTime.Now.AddYears(-3)),
                IsCurrentEmployee = true,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now)
            },
                                    new Employee
            {
                EmployeeId = 18,
                PersonalId = "01010000018",
                Name = "James",
                Surname = "HRHead",
                OrganizationalUnit = OrganizationalUnitsDbMock._organizationalUnits.First(u => u.UnitId == 6), // HR Department
                Position = PositionsDbMock._positions.First(p => p.PositionId == 10), // Head of HR
                EmploymentStartDate = DateOnly.FromDateTime(DateTime.Now.AddYears(-3)),
                IsCurrentEmployee = true,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now)
            }
        ];
    }
}
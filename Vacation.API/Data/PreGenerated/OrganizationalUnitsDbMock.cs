using Vacation.API.Models;

namespace Vacation.API.Data.PreGenerated
{
    internal class OrganizationalUnitsDbMock
    {
        internal static List<OrganizationalUnit> _organizationalUnits = new List<OrganizationalUnit>();

        static OrganizationalUnitsDbMock()
        {
            // Create the organizational units first
            var itDepartment = new OrganizationalUnit
            {
                UnitId = 1,
                Name = "IT Department",
                UnitType = UnitType.Department,
                ParentUnit = null,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now.AddYears(-5)),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now)
            };

            var developmentTeam = new OrganizationalUnit
            {
                UnitId = 2,
                Name = "Development Team",
                UnitType = UnitType.Team,
                ParentUnit = itDepartment,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now.AddYears(-3)),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now)
            };

            var qaTeam = new OrganizationalUnit
            {
                UnitId = 3,
                Name = "QA Team",
                UnitType = UnitType.Team,
                ParentUnit = itDepartment,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now.AddYears(-2)),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now)
            };

            var frontendSubTeam = new OrganizationalUnit
            {
                UnitId = 4,
                Name = "Frontend SubTeam",
                UnitType = UnitType.SubTeam,
                ParentUnit = developmentTeam,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now.AddMonths(-18)),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now)
            };

            var backendSubTeam = new OrganizationalUnit
            {
                UnitId = 5,
                Name = "Backend SubTeam",
                UnitType = UnitType.SubTeam,
                ParentUnit = developmentTeam,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now.AddMonths(-12)),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now)
            };

            var hrDepartment = new OrganizationalUnit
            {
                UnitId = 6,
                Name = "HR Department",
                UnitType = UnitType.Department,
                ParentUnit = null,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now.AddYears(-5)),
                UpdatedAt = DateOnly.FromDateTime(DateTime.Now)
            };

            _organizationalUnits.Add(itDepartment);
            _organizationalUnits.Add(developmentTeam);
            _organizationalUnits.Add(qaTeam);
            _organizationalUnits.Add(frontendSubTeam);
            _organizationalUnits.Add(backendSubTeam);
            _organizationalUnits.Add(hrDepartment);
        }
    }
}
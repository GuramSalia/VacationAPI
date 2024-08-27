namespace Vacation.API.Models
{
    public enum UnitType
    {
        Department,
        Team,
        SubTeam
    }

    public class OrganizationalUnit
    {
        public int UnitId { get; set; }
        public string Name { get; set; } = string.Empty;
        public UnitType UnitType { get; set; }
        public OrganizationalUnit? ParentUnit { get; set; }
        public ICollection<OrganizationalUnit> ChildUnits { get; set; } = new List<OrganizationalUnit>();
        public DateOnly CreatedAt { get; set; }
        public DateOnly UpdatedAt { get; set; }
    }
}
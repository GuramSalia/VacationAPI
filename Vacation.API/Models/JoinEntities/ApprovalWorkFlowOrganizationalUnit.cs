namespace Vacation.API.Models.JoinEntities
{
    public class ApprovalWorkFlowOrganizationalUnit
    {
        public int WorkFlowId { get; set; }
        public ApprovalFlow WorkFlow { get; set; } = new ApprovalFlow();

        public int OrganizationalUnitId { get; set; }
        public OrganizationalUnit OrganizationalUnit { get; set; } = new OrganizationalUnit();
    }
}
namespace Vacation.API.Models.JoinEntities
{
    public class ApprovalWorkFlowOrganizationalUnit
    {
        public int WorkFlowId { get; set; }
        public ApprovalWorkFlow WorkFlow { get; set; } = new ApprovalWorkFlow();

        public int OrganizationalUnitId { get; set; }
        public OrganizationalUnit OrganizationalUnit { get; set; } = new OrganizationalUnit();
    }
}
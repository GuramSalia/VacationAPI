using Vacation.API.Models.Enums;

namespace Vacation.API.Models
{
    public class VacationApproval
    {
        public int VacationApprovalId { get; set; }
        public VacationRequest VacationRequest { get; set; } = new VacationRequest();
        public Employee Approver { get; set; } = new Employee();
        public DateTime? ApprovalDate { get; set; }
        public Decision Decision { get; set; } = Decision.Pending; // maybe it should be Status? when status is approved or denied it is a decision.
        public string? Comment { get; set; }
    }
}
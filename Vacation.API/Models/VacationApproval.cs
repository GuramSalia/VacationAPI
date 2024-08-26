using Vacation.API.Models.Enums;

namespace Vacation.API.Models
{
    public class VacationApproval
    {
        public int VacationApprovalId { get; set; }
        public VacationRequest VacationRequest { get; set; } = new VacationRequest();

        public Employee Approver { get; set; } = new Employee();

        public DateTime ApprovalDate { get; set; } = new DateTime();

        public Decision Decision { get; set; } = Decision.Pending;

        public string? Comment { get; set; }
    }
}
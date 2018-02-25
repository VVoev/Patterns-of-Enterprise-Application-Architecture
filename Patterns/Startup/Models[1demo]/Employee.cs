using System;

namespace Startup.Models_1demo
{
    public class Employee : IExpenceApprover
    {
        public Employee(string name, Decimal approvalLimit)
        {
            this.Name = name;
            this.approvalLimit = approvalLimit;
        }

        public string Name { get; set; }
        private readonly Decimal approvalLimit;

        public ApprovalResponse ApproveExpence(IExpenceReport report)
        {
            return report.Total > approvalLimit ? ApprovalResponse.BeyondTheLimit : ApprovalResponse.Approved;
        }
    }

}

namespace Startup.Models_1demo
{
    class ExpenceHandler : IExpenceHandler
    {
        private readonly IExpenceApprover approver;
        private IExpenceHandler next;
        public ExpenceHandler(IExpenceApprover approver)
        {
            this.approver = approver;
            this.next = EndOfChainExpenceHandler.Instance;
        }

        public void RegisterNext(IExpenceHandler handler)
        {
            next = handler;
        }

        public ApprovalResponse Approve(IExpenceReport expenceReport)
        {
            ApprovalResponse response = this.approver.ApproveExpence(expenceReport);

            if (response == ApprovalResponse.BeyondTheLimit)
            {
                return next.Approve(expenceReport);
            }

            return response;
        }
    }

}

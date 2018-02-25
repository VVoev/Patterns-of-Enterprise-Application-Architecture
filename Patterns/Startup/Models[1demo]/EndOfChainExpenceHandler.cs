using System;

namespace Startup.Models_1demo
{
    public class EndOfChainExpenceHandler : IExpenceHandler
    {
        private static EndOfChainExpenceHandler instance = new EndOfChainExpenceHandler();
        private EndOfChainExpenceHandler()
        {
        }

        public static EndOfChainExpenceHandler Instance
        {
            get
            {
                return instance;
            }
        }
        public ApprovalResponse Approve(IExpenceReport expenceReport)
        {
            return ApprovalResponse.Denied;
        }

        public void RegisterNext(IExpenceHandler handler)
        {
            throw new InvalidOperationException("End of chain handler must be the END of a chain");
        }
    }

}

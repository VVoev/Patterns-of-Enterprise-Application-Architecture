using System;

namespace Startup.Models_2demo_
{
    public class TeamLead : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000)
            {
                Console.WriteLine(
                "{0} approved request #{1}",
                this.GetType().Name,
                purchase.Number);
            }
            else if (this.Successor != null)
            {
                this.Successor.ProcessRequest(purchase);
            }
        }
    }
}

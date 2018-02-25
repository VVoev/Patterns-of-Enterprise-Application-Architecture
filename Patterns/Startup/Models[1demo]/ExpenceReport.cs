using System;

namespace Startup.Models_1demo
{
    public class ExpenceReport : IExpenceReport
    {

        public ExpenceReport(Decimal total)
        {
            this.Total = total;
        }
        public decimal Total { get; private set; }
    }

}

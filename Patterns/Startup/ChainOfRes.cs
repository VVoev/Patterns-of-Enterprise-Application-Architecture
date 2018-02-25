using Startup.Models_1demo;
using Startup.Models_2demo_;
using System;

namespace Startup
{
    public static class ChainOfRes
    {
        public static void FirstDemo()
        {
            ExpenceHandler william = new ExpenceHandler(new Employee("Wiliam Worker", Decimal.Zero));
            ExpenceHandler mary = new ExpenceHandler(new Employee("Mary Manager", new Decimal(1000)));
            ExpenceHandler victor = new ExpenceHandler(new Employee("Victor VicePrezident", new Decimal(5000)));
            Models_1demo.ExpenceHandler paula = new ExpenceHandler(new Employee("Henry Director", new Decimal(20000)));

            william.RegisterNext(mary);
            mary.RegisterNext(victor);
            victor.RegisterNext(paula);

            Decimal expenceReportAmount = decimal.Parse(Console.ReadLine());

            IExpenceReport expence = new ExpenceReport(expenceReportAmount);

            ApprovalResponse response = william.Approve(expence);
            Console.WriteLine($"The request was {response}");
        }

        public static void SecondDemo()
        {
            Approver teamLead = new TeamLead();
            Approver vp = new VicePrezicent();
            Approver ceo = new President();
            teamLead.SetSuccessor(vp);
            vp.SetSuccessor(ceo);
            teamLead.ProcessRequest(new Purchase(2033, 9999));
            teamLead.ProcessRequest(new Purchase(2034, 350.00));
            teamLead.ProcessRequest(new Purchase(2035, 24000));
            teamLead.ProcessRequest(new Purchase(2036, 50000));
            teamLead.ProcessRequest(new Purchase(2037, 500000));
        }
    }
}
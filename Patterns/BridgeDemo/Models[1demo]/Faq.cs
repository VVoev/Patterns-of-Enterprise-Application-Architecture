using System;
using System.Collections.Generic;

namespace BridgeDemo.Models_1demo_
{
    class Faq : Printer
    {
        public Faq(IFormater formater) : base(formater)
        {
        }

        public string Title { get; set; }

        public Dictionary<string, string> Questions { get; set; } = new Dictionary<string, string>();

        public override void Print()
        {
            Console.WriteLine(formater.Format("Title", Title));
            foreach (var quesiton in Questions)
            {
                Console.WriteLine(formater.Format("Questions", quesiton.Key));
                Console.WriteLine(formater.Format("Answers", quesiton.Value));
            }
            Console.WriteLine();
        }
    }
}

using System;

namespace BridgeDemo.Models_1demo_
{
    class TermPaper : Printer
    {
        public TermPaper(IFormater formater) : base(formater)
        {
        }

        public string Class { get; set; }
        public string Student { get; set; }
        public string Text { get; set; }
        public string Reference { get; set; }

        public override void Print()
        {
            Console.WriteLine(formater.Format("Class", Class));
            Console.WriteLine(formater.Format("Student", Student));
            Console.WriteLine(formater.Format("Text", Text));
            Console.WriteLine(formater.Format("Reference", Reference));

            Console.WriteLine();
        }
    }
}

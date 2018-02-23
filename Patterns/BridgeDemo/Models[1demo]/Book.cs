using System;

namespace BridgeDemo.Models_1demo_
{
    class Book : Printer
    {
        public Book(IFormater formater) : base(formater)
        {
        }

        public string Title { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }

        public override void Print()
        {
            Console.WriteLine(formater.Format("Title", Title));
            Console.WriteLine(formater.Format("Text", Text));
            Console.WriteLine(formater.Format("Author", Author));
            Console.WriteLine();
        }

    }
}

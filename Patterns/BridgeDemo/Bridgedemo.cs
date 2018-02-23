using BridgeDemo.Models_1demo_;
using System;
using System.Collections.Generic;

namespace BridgeDemo
{
    public static class Bridgedemo
    {
        public static void FirstDemo()
        {
            var standartFormatter = new StandartFormatter();
            var reverseFormatter = new ReverseFormatter();
            var crazyFormatter = new CrazyFormater();
            var book = new Book(standartFormatter) { Author = "Shawn O Briang", Text = "Cool book about how i lost my life", Title = "7 Circles Of Hell" };
            var termPaper = new TermPaper(reverseFormatter) { Class = "Designs Patterns", Student = "Vladimir Voev", Text = "Bridge Pattern", Reference = "WWW=)" };
            var faq = new Faq(crazyFormatter) { Title = "Bridge Pattern ??" };
            faq.Questions.Add("What is this", "A Dessign Pattern");
            faq.Questions.Add("When is good to be used", "When you need to separate an abstraction from an implementation");

            var printer = new List<Printer>();
            printer.Add(book);
            printer.Add(termPaper);
            printer.Add(faq);
            GenerateReport(printer);
        }

        private static void GenerateReport(List<Printer> printer)
        {
            foreach (var item in printer)
            {
                item.Print();
            }
            Console.ReadKey();
        }
    }
}

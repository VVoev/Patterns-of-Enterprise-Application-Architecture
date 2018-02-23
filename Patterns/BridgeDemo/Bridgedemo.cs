using BridgeDemo.Model_3demo_;
using BridgeDemo.Models_1demo_;
using BridgeDemo.Models_2demo_;
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

        public static void ThirdDemo()
        {
            var living = new Cat();
            IPresenter tiger = new Tiger();
            IPresenter zebra = new Zebra();
            tiger.Introduce(8, "Djini");

            living.presenter = tiger;
            living.presenter.Introduce(22, "Qnko");

            living.presenter = zebra;
            living.presenter.Introduce(15, "Nina");
        }

        public static void SecondDemo()
        {
            IMessageSender email = new EmailSender();
            IMessageSender queue = new MSMQSender();
            IMessageSender web = new WebServiceSender();

            Message message = new SystemMessage();
            message.Subject = "Test Message";
            message.Body = "Hi, This is a Test Message";

            message.MessageSender = email;
            message.Send();

            message.MessageSender = queue;
            message.Send();

            message.MessageSender = web;
            message.Send();

            UserMessage usermsg = new UserMessage();
            usermsg.Subject = "Test Message";
            usermsg.Body = "Hi, This is a Test Message";
            usermsg.UserComments = "I hope you are well";

            usermsg.MessageSender = email;
            usermsg.Send();

            Console.ReadKey();
        }


        #region GenerateReport
        private static void GenerateReport(List<Printer> printer)
        {
            foreach (var item in printer)
            {
                item.Print();
            }
            Console.ReadKey();
        }
        #endregion
    }
}

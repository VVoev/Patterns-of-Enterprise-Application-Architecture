using MediatorDemo.Models_1Demo_;
using MediatorDemo.Models_2Demo_;
using System;

namespace MediatorDemo
{
    class Startup
    {
        static void Main(string[] args)
        {
             FirstDemo();
            
             SecondDemo();
        }

        private static void FirstDemo()
        {
            ConcreteMediator m = new ConcreteMediator();

            ConcreteColleague1 c1 = new ConcreteColleague1(m);
            ConcreteColleague2 c2 = new ConcreteColleague2(m);

            m.Colegue1 = c1;
            m.Colegue2 = c2;

            c1.Send("How are you?");
            c2.Send("Fine, thanks");

            // Wait for user

            Console.ReadKey();
        }

        private static void SecondDemo()
        {
            ChatRoom chatroom = new ChatRoom();

            // Create participants and register them

            Participant George = new Beatle("George");
            Participant Paul = new Beatle("Paul");
            Participant Ringo = new Beatle("Ringo");
            Participant John = new Beatle("John");
            Participant Yoko = new NonBeattle("Yoko");

            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);

            // Chatting participants

            Yoko.Send("John", "Hi John!");
            Paul.Send("Ringo", "All you need is love");
            Ringo.Send("George", "My sweet Lord");
            Paul.Send("John", "Can't buy me love");
            John.Send("Yoko", "My sweet love");

            // Wait for user

            Console.ReadKey();
        }
    }
  
}

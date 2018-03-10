using System;

namespace MediatorDemo.Models_1Demo_
{
    /// <summary>

    /// The 'Mediator' abstract class

    /// </summary>
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague collegue);
    }

    public class ConcreteMediator : Mediator
    {
        private ConcreteColleague1 collegue1;
        private ConcreteColleague2 collegue2;


        public ConcreteColleague1 Colegue1
        {
            set
            {
                this.collegue1 = value;
            }
        }

        public ConcreteColleague2 Colegue2
        {
            set
            {
                this.collegue2 = value;
            }
        }
        public override void Send(string message, Colleague collegue)
        {
            if (collegue == collegue1)
            {
                collegue2.Notify(message);
            }
            else
            {
                collegue1.Notify(message);
            }
        }
    }

    public abstract class Colleague

    {
        protected Mediator mediator;
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }

    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"Collegue 1 gets the message {message}");
        }
    }

    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"Collegue 2 gets the message {message}");
        }
    }
}

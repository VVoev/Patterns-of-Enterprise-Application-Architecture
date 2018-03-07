using System;

namespace NullPattern.Models_1demo_
{
    public abstract class Automobile
    {
        public abstract Guid Id { get; }

        public abstract string Name { get; }

        public abstract void Start();

        public abstract void Stop();

        static readonly NullAutomobile nullAutomobile = new NullAutomobile();

        public static NullAutomobile NULL
        {
            get
            {
                return nullAutomobile;
            }
        }
    }

    public class NullAutomobile : Automobile
    {
        public override Guid Id
        {
            get
            {
                return Guid.Empty;
            }
        }

        public override string Name
        {
            get
            {
                return string.Empty;
            }
        }

        public override void Start()
        {

        }

        public override void Stop()
        {

        }
    }

    public class AutoRepository
    {
        public Automobile Find(string name)
        {
            if (name.ToLower().Contains("bmw"))
            {
                return new BmwM3();
            }

            return Automobile.NULL;
        }
    }

    public class BmwM3 : Automobile
    {
        public override Guid Id
        {
            get
            {
                return Guid.NewGuid();
            }
        }

        public override string Name
        {
            get
            {
                return "Bmw m3 450Bhp";
            }
        }

        public override void Start()
        {
            Console.WriteLine($"{this.GetType().Name} started");
        }

        public override void Stop()
        {
            Console.WriteLine($"{this.GetType().Name} stoped");
        }
    }
}

using System;

namespace CompositeDemo.Models_1demo_
{
    public class Person : IParty
    {
        public Person()
        {
        }

        public int Gold { get; set; }

        public string Name { get; set; }

        public void Stats()
        {
            Console.WriteLine($"{Name} has gold {Gold}");
        }
    }
}

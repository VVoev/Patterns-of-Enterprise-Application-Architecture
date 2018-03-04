using System;

namespace FlyweightPattern.Models_1demo_
{
    public class UnsharedConcreteFlyweight : FlyWeight

    {
        public override void Operation(int state)
        {
            Console.WriteLine("UnsharedConcreteFlyweight: " +
              state);
        }
    }

}

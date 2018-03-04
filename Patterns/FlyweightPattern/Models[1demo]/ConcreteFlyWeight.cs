using System;

namespace FlyweightPattern.Models_1demo_
{
    public class ConcreteFlyWeight : FlyWeight
    {
        public override void Operation(int state)
        {
            Console.WriteLine("ConcreteFlyWeight " + state);
        }
    }

}

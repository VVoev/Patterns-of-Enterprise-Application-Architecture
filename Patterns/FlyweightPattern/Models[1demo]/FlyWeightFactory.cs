using System.Collections;

namespace FlyweightPattern.Models_1demo_
{
    public class FlyWeightFactory
    {
        private Hashtable flyweight = new Hashtable();

        public FlyWeightFactory()
        {
            flyweight.Add("X", new ConcreteFlyWeight());
            flyweight.Add("Y", new ConcreteFlyWeight());
            flyweight.Add("Z", new ConcreteFlyWeight());
        }

        public FlyWeight GetFlyWeight(string key)
        {
            return ((FlyWeight)flyweight[key]);
        }
    }

}

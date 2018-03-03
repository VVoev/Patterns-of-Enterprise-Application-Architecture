using System;

namespace FactoryPatternDemo._AbstractFactory_
{
    public abstract class Car
    {
        int HorsePower { get; }

        double EngineSize { get; }

        public virtual void IntroDuce(int horsePowers, double engineSize)
        {
            Console.WriteLine($"My engine is {engineSize} liter and my horsePowers are {horsePowers}");
        }
    }

}

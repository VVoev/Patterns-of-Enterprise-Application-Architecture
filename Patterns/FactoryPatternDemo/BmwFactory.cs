using System;

namespace FactoryPatternDemo
{
    public class BmwFactory : IAutoFactory
    {
        public BmwFactory()
        {

        }

        public IAutomobile CreateEcenomyCar()
        {
            return new Bmw328();
        }

        public IAutomobile CreateLuxuryCar()
        {
            return new Bmw760();
        }

        public IAutomobile CreateSportsCar()
        {
            return new BmwM3();
        }
    }

    public abstract class Car
    {
        int HorsePower { get; }

        double EngineSize { get; }

        public virtual void IntroDuce(int horsePowers,double engineSize)
        {
            Console.WriteLine($"My engine is {engineSize} liter and my horsePowers are {horsePowers}");
        }
    }

    public class Bmw328 : Car, IAutomobile
    {
        public double EngineSize
        {
            get
            {
                return 2.8;
            }
        }

        public int HorsePower
        {
            get
            {
                return 245;
            }
        }

        public void IntroDuce()
        {
             base.IntroDuce(HorsePower, EngineSize);
        }
    }

    public class Bmw760 : Car,IAutomobile
    {
        public double EngineSize
        {
            get
            {
                return 6.0;
            }
        }

        public int HorsePower
        {
            get
            {
                return 555;
            }
        }

        public void IntroDuce()
        {
            base.IntroDuce(HorsePower, EngineSize);
        }
    }

    public class BmwM3 : Car,IAutomobile
    {
        public double EngineSize
        {
            get
            {
                return 4.4;
            }
        }

        public int HorsePower
        {
            get
            {
                return 455;
            }
        }

        public void IntroDuce()
        {
            base.IntroDuce(HorsePower, EngineSize);
        }
    }

    public interface IAutoFactory
    {
        IAutomobile CreateSportsCar();
        IAutomobile CreateLuxuryCar();
        IAutomobile CreateEcenomyCar();
    }

    public interface IAutomobile
    {
        int HorsePower { get; }

        double EngineSize { get; }

        void IntroDuce();
    }
}
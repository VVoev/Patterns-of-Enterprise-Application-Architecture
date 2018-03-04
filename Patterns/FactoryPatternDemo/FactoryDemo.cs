using FactoryPatternDemo._AbstractFactory_;
using FactoryPatternDemo._ReflectionFactory_;
using System;

namespace FactoryPatternDemo
{
    public class FactoryDemo
    {
        public static void InitializeReflectionDemo()
        {
            string carCommand = Console.ReadLine();

            AutoFactory factory = new AutoFactory();

            IAuto car = factory.CreateInstance(carCommand);
            car.TurnOn();
            car.TurnOff();
        }

        public static void AbstractFactoryDemo()
        {
            var bmwFactory = new BmwFactory();
            IAutomobile myCar = bmwFactory.CreateSportsCar();
            myCar.IntroDuce();
            Console.WriteLine(myCar.GetType().Name);
        }

        public static void SwitchCaseDemo()
        {
            string carCommand = Console.ReadLine();

            IAuto car = SwichCaseFactory.GetCar(carCommand);
            car.TurnOn();
            car.TurnOff();
        }
    }
}
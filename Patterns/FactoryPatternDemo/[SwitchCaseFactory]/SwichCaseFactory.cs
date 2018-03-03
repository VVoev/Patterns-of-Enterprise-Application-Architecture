using FactoryPatternDemo._ReflectionFactory_;

namespace FactoryPatternDemo
{
    public class SwichCaseFactory
    {
        public static IAuto GetCar(string carCommand)
        {
            switch (carCommand)
            {
                case "bmw335": return new BMW335i();
                case "audia7": return new AudiA7();
                default:
                    return new NullCar();
            }
        }
    }
}
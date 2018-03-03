namespace FactoryPatternDemo._AbstractFactory_
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

}

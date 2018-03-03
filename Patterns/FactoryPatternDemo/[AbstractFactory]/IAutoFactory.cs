namespace FactoryPatternDemo._AbstractFactory_
{
    public interface IAutoFactory
    {
        IAutomobile CreateSportsCar();
        IAutomobile CreateLuxuryCar();
        IAutomobile CreateEcenomyCar();
    }
}


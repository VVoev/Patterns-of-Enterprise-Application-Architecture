namespace FactoryPatternDemo._ReflectionFactory_
{
    public interface IAuto
    {
        string Name { get; }

        void SetName(string name);
        void TurnOn();
        void TurnOff();
    }

}

namespace FactoryPatternDemo
{
    class Startup
    {
        static void Main(string[] args)
        {
            FactoryDemo.InitializeReflectionDemo();

            FactoryDemo.SwitchCaseDemo();

            FactoryDemo.AbstractFactoryDemo();        
        } 
    }
}
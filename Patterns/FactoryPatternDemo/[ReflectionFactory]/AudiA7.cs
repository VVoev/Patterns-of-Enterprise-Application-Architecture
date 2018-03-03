using System;

namespace FactoryPatternDemo._ReflectionFactory_
{
    public class AudiA7 : IAuto
    {
        public string Name
        {
            get
            {
                return "I am Audi A7";
            }
        }

        public void SetName(string name)
        {
            throw new NotImplementedException();
        }

        public void TurnOff()
        {
            Console.WriteLine($"{this.Name} Is Off");

        }

        public void TurnOn()
        {
            Console.WriteLine($"{this.Name} Is On");

        }
    }

}

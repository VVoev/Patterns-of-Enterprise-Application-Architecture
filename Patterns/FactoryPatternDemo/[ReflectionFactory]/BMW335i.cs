using System;

namespace FactoryPatternDemo._ReflectionFactory_
{
    public class BMW335i : IAuto
    {
        public string Name
        {
            get
            {
                return "I am 335i";
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

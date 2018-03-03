using System;

namespace FactoryPatternDemo._ReflectionFactory_
{
    public class NullCar : IAuto
    {

        public NullCar()
        {
            throw new ArgumentNullException("Invalid Car");
        }

        public string Name
        {
            get
            {
                throw new ArgumentNullException("Invalid Car");
            }
        }

        public void SetName(string name)
        {
            throw new NotImplementedException();
        }

        public void TurnOff()
        {
            throw new NotImplementedException();
        }

        public void TurnOn()
        {
            throw new NotImplementedException();
        }
    }
}

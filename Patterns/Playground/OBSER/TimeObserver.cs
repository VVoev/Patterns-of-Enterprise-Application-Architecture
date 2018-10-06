using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    public class TimeObserver : ISubscriber
    {
        public void Notify(IGood good)
        {
            Console.WriteLine($"Price has changed on {good.GetType().Name} {DateTime.Now.TimeOfDay} and is now {good.Price}");
        }
    }
}

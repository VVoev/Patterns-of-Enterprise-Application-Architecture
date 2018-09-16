using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo.Models_5demo_
{
    class UsbPort : IConvertor
    {
        public void CatchAndDisplay()
        {
            Console.WriteLine($"I am {this.GetType().Name} and i run USB");
        }
    }
}

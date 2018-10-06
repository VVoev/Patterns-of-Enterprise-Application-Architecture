using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    class ConsoleWriter : IWriter
    {
        public void WriteMessage(string msg)
        {
            Console.WriteLine($"I Am a {this.GetType().Name} and this is my msg : {msg} written on the console");
        }
    }
}

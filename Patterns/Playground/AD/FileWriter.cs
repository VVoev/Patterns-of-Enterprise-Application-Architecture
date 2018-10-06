using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    public class FileWriter : IWriter
    {
        public void WriteMessage(string msg)
        {
            Console.WriteLine($"I Am a {this.GetType().Name} and this is my msg : {msg} written on the FS");
        }
    }
}

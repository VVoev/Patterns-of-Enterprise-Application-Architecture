using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    public class GenericWriter : IWriter
    {
        private readonly IWriter writer;
        public GenericWriter(IWriter writer)
        {
            this.writer = writer;
        }
        public void WriteMessage(string msg)
        {
            Console.WriteLine("------> ADAPTER");
            this.writer.WriteMessage(msg);
        }
    }
}

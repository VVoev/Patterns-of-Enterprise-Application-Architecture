using System;
using System.Collections.Generic;
using System.Text;

namespace Playground.COR
{
    public abstract class Employee
    {
        protected Employee successor;
        public string Name { get; set; }
        public int Budget { get; set; }
        public Employee(string name, int budget)
        {
            this.Name = name;
            this.Budget = budget;
        }

        public void Set_Successor(Employee successor)
        {
            this.successor = successor;
        }

        public void Process_Invoices(int amount)
        {
            if (amount < this.Budget)
            {
                Console.WriteLine($"Request is handled by {this.GetType().Name}");
            }
            else if (this.successor != null)
            {
                successor.Process_Invoices(amount);
            }
            else
            {
                Console.WriteLine("Qko si eba maikata");
            }
        }
    }


    public class Junior : Employee
    {
        public Junior(string name, int budget) : base(name, budget)
        {
        }
    }

    public class Mid : Employee
    {
        public Mid(string name, int budget) : base(name, budget)
        {
        }
    }

    public class Senior : Employee
    {
        public Senior(string name, int budget) : base(name, budget)
        {
        }
    }
}

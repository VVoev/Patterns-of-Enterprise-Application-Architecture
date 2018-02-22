using AdapterDemo.Models;
using AdapterDemo.Models_2demo_;
using AdapterDemo.Models_3demo_;
using System;

namespace AdapterDemo
{
    public static class AdapterDemo
    {

        public static void FirstDemo()
        {
            // Non-adapted chemical compound

            Compound unknown = new Compound("Unknown");
            unknown.Display();

            // Adapted chemical compounds

            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
        }

        public static void SecondDemo()
        {
            IMathematicalAdapter adapter = null;

            //Let emulate the decision where the choice of using the underlying system is made
            Console.WriteLine("Enter which library you wanna use to do operation {1,2}");
            int x = Console.Read();

            if (x == '1')
            {
                //Let us choose to use Library one to do something
                adapter = new AdapterOne();
            }
            else if (x == '2')
            {
                //Let us choose to use Library two to do something
                adapter = new AdapterTwo();
            }

            //Just do the operation now
            adapter.PerformOperation();
            Console.WriteLine();
        }

        public static void ThirdDemo()
        {
            IPerson managerOrEmployeee = null;
            IPerson employeeOrManager = null;

            //Based on the need person can be both Manager Or Employee and simply provide a One level of Abstraction
            managerOrEmployeee = new ManagerAdapter();
            employeeOrManager = new EmployeeAdapter();

            Console.WriteLine($"{managerOrEmployeee.GetType().Name} have a salary of {managerOrEmployeee.CalculateSalary()} Euro");
            Console.WriteLine($"{employeeOrManager.GetType().Name} have a salary of {employeeOrManager.CalculateSalary()} Euro");

        }
    }
}

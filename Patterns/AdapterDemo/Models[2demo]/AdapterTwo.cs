using System;

namespace AdapterDemo.Models_2demo_
{
    //Adapter for second library
    class AdapterTwo : IMathematicalAdapter
    {
        private LibraryForMultiPlying two = null;

        public AdapterTwo()
        {
            two = new LibraryForMultiPlying();
        }
        public void PerformOperation()
        {
            Console.WriteLine(two.ThisIsHowTwoDoesIt(5, 5) + "\n"); ;
        }

    }
}

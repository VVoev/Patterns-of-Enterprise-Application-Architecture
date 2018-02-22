namespace AdapterDemo.Models_2demo_
{
    //Adapter for first library
    class AdapterOne : IMathematicalAdapter
    {
        private LibraryForCalculation one = null;

        public AdapterOne()
        {
            one = new LibraryForCalculation();
        }

        public void PerformOperation()
        {
            one.ThisIsHowOneDoesIt(5, 5);
        }

    }
}

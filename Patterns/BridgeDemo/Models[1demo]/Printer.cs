namespace BridgeDemo.Models_1demo_
{
    abstract class Printer
    {
        abstract public void Print();

        protected readonly IFormater formater;

        public Printer(IFormater formater)
        {
            this.formater = formater;
        }
    }
}

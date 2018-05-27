namespace StrategyDemo.Domain_BL_
{
    public class Order
    {
        
        public Order()
        {
            this.Id = Provider.IdNumber();
        }


        public int Id { get; }




    }

    public static class Provider
    {
        static int counter;
        public static  int IdNumber()
        {
            return ++counter;
        }
    }
}
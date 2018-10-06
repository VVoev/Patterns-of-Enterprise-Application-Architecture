namespace Playground
{
    public class PriceObserver : ISubscriber
    {
        public PriceObserver()
        {
            
        }

        public void CheckIfPriceIsGood(IGood good)
        {
            System.Console.WriteLine(good.Price);
        }

        public void Notify(IGood good)
        {

            CheckIfPriceIsGood(good);
        }
    }
}
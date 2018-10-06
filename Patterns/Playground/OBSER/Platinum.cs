using System.Collections.Generic;

namespace Playground
{
    public class Platinum : IGood
    {
        private IList<ISubscriber> subscribers;
        public int Price { get; set; }

        public Platinum(int price)
        {
            this.Price = price;
            this.subscribers = new List<ISubscriber>();

        }

        public void addSubsriber(ISubscriber subscriber)
        {
            this.subscribers.Add(subscriber);
        }

        public void PriceUp()
        {
            this.Price += 4330;
            NotifyAllSubscribers(this);
        }

        public void PriceDown()
        {
            this.Price -= 4330;
            NotifyAllSubscribers(this);
        }


        private void NotifyAllSubscribers(Platinum platinum)
        {
            foreach (var subs in this.subscribers)
            {
                subs.Notify(platinum);
            }
        }
    }
}
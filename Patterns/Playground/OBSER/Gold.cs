using System;
using System.Collections.Generic;

namespace Playground
{
    public class Gold : IGood
    {
        private IList<ISubscriber> subscribers;

        public void addSubsriber(ISubscriber subscriber)
        {
            this.subscribers.Add(subscriber);
        }

        public int Price { get; set; }

        public Gold(int price)
        {
            this.Price = price;
            this.subscribers = new List<ISubscriber>();

        }


        public void PriceUp()
        {
            this.Price += 30;
            NotifyAllSubscribers(this);
        }

        public void PriceDown()
        {
            this.Price -= 30;
            NotifyAllSubscribers(this);
        }

        private void NotifyAllSubscribers(Gold gold)
        {
            foreach (var subs in this.subscribers)
            {
                subs.Notify(gold);
            }
        }


        public void RemoveObserver(ISubscriber subscriber)
        {
            Console.WriteLine($"{subscriber.GetType().Name} has been removed");
            this.subscribers.Remove(subscriber);
        }
    }
}
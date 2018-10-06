using System;

namespace PlayGround2
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new Item("beer",20);
            item.calculateShipping(new FedEx());
            item.calculateShipping(new Dhs());
            item.calculateShipping(new Econt());
        }
    }

    public class Item
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public IShippingProvider shippingProvider;
        public Item(string name,int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public void calculateShipping()
        {
            if(shippingProvider == null)
            {
                InjectProvider(shippingProvider);
            }
            Console.WriteLine(this.Price + shippingProvider.CalculateShipping());
        }

        private void InjectProvider(IShippingProvider shippingProvider)
        {
            this.shippingProvider = shippingProvider;
        }
    }

    public interface IShippingProvider
    {
        double CalculateShipping();
    }

    public class FedEx : IShippingProvider
    {
        public double CalculateShipping()
        {
            return 4.25;
        }
    }

    public class Dhs : IShippingProvider
    {
        public double CalculateShipping()
        {
            return 15.00;
        }
    }

    public class Econt : IShippingProvider
    {
        public double CalculateShipping()
        {
            return 8;
        }
    }
}

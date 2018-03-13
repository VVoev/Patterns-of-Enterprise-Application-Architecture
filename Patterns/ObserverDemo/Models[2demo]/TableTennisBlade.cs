using System.Collections.Generic;

namespace ObserverDemo.Models_2demo_
{
    public class TableTennisBlade
    {
        public int Speed { get; set; }

        public int Control { get; set; }

        public double Price { get; set; }

        public string Name { get; set; }

        public TableTennisBlade(int speed, int control, double price, string name)
        {
            this.Speed = speed;
            this.Control = control;
            this.Price = price;
            this.Name = name;
        }
    }

    public class Data
    {
        public static List<TableTennisBlade> shopData = new List<TableTennisBlade>()
        {
            new TableTennisBlade(9,9,110.99,"Timo Boll"),
            new TableTennisBlade(9,9,99.99,"Mizutani"),
            new TableTennisBlade(9,9,118.99,"Primorac Off-"),
            new TableTennisBlade(9,9,121.99,"Ma long ZLC"),
            new TableTennisBlade(9,9,145.99,"Apolonia ZLF")
        };

        public IEnumerable<TableTennisBlade> GetNext()
        {
            for (int i = 0; i < shopData.Count; i++)
            {
                yield return shopData[i];
            }
        }

        public int GetDataLenght
        {
            get
            {
                return shopData.Count;
            }
        }
    }

    public abstract class AbstractTennisObserver
    {
        public abstract void Update();
    }

    public abstract class AbstractSubject
    {
        List<AbstractTennisObserver> observers = new List<AbstractTennisObserver>();

        public void Register(AbstractTennisObserver observer)
        {
            observers.Add(observer);
        }

        public void Unregister(AbstractTennisObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observe in observers)
            {
                observe.Update();
            }
        }
    }

    public class StockTic : AbstractSubject
    {
        private TableTennisBlade stock;


        public TableTennisBlade Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                this.stock = value;
                this.Notify();
            }
        }
    }

    public class AsianBuyer : AbstractTennisObserver
    {
        private StockTic data;
        public AsianBuyer(StockTic data)
        {
            this.data = data;
            data.Register(this);
        }
        public override void Update()
        {
            System.Console.WriteLine($"{data.Stock.Name} price is now {data.Stock.Price}");
            double price = data.Stock.Price;
        }
    }
}

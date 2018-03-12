using System.Collections.Generic;

namespace ObserverDemo
{
    class Startup
    {
        static void Main(string[] args)
        {
            StockTicker ticker = new StockTicker();

            GoogleObserver gobs = new GoogleObserver(ticker);
            MicrosoftObserver mobs = new MicrosoftObserver(ticker);

            foreach (var data in SampleData.GetNext())
            {
            {
                    ticker.Stock = data;
                }
            }
        }


    }

    public class SampleData
    {
        private static decimal[] samplePrices = new decimal[] { 10.00m, 10.25m, 13.00m, 18.25m, 50.00m };
        private static string[] sampleStocks = new string[] { "MSFT", "GOOGLE", "YAHOO", "OMV", "NASDAQ" };

        public static IEnumerable<Stock> GetNext()
        {
            for (int i = 0; i < samplePrices.Length; i++)
            {
                Stock s = new Stock();
                s.Symbol = sampleStocks[i];
                s.Price = samplePrices[i];
                yield return s;

            }
        }
    }

    public class Stock
    {
        public decimal Price { get; set; }

        public string Symbol { get; set; }
    }

    public class StockTicker : AbstractSubject
    {
        private Stock stock;

        public Stock Stock
        {
            get
            {
                return stock;
            }
            set
            {
                this.stock = value;
                this.Notify();
            }
        }
    }

    public abstract class AbstractObserver
    {
        public abstract void Update();
    }

    public abstract class AbstractSubject
    {
        List<AbstractObserver> observers = new List<AbstractObserver>();

        public void Register(AbstractObserver observer)
        {
            observers.Add(observer);
        }

        public void Unregister(AbstractObserver observer)
        {
            observers.Remove(observer);
        }


        public void Notify()
        {
            foreach (var o in observers)
            {
                o.Update();
            }
        }
    }

    public class MicrosoftObserver : AbstractObserver
    {
        private StockTicker DataSource { get; set; }
        public MicrosoftObserver(StockTicker ticker)
        {
            this.DataSource = ticker;
            ticker.Register(this);
        }

        public override void Update()
        {
            decimal price = DataSource.Stock.Price;
            string symbol = DataSource.Stock.Symbol;
        }
    }

    public class GoogleObserver : AbstractObserver
    {
        private StockTicker DataSource { get; set; }
        public GoogleObserver(StockTicker ticker)
        {
            this.DataSource = ticker;
            ticker.Register(this);
        }

        public override void Update()
        {
            decimal price = DataSource.Stock.Price;
            string symbol = DataSource.Stock.Symbol;
        }
    }
}

using ObserverDemo.Models_1demo_;
using ObserverDemo.Models_2demo_;

namespace ObserverDemo
{
    public class Presentor
    {
        public static void FirstDemo()
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

        public static void SecondDemo()
        {
            StockTic ticker = new StockTic();

            AsianBuyer ab = new AsianBuyer(ticker);

            var datas = new Data();

            foreach (var data in Data.shopData)
            {
                ticker.Stock = data;
            }
        }
    }
}
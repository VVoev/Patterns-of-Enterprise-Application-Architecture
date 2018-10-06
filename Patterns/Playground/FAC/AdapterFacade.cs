using Playground.COR;
using System;

namespace Playground
{
    public class AdapterFacade
    {

        public static void LaunchFifth()
        {
            var jun = new Junior("Ivan", 300);
            var mid = new Mid("Bob", 1000);
            var sen = new Senior("Stef", 1100);

            jun.Set_Successor(mid);
            mid.Set_Successor(sen);
            jun.Process_Invoices(1200);
        }
        public static  void Launch()
        {
            IWriter writer = new ConsoleWriter();
            writer.WriteMessage("I am hunter i am fisherman");
            writer = new GenericWriter(new FileWriter());
            writer.WriteMessage("I am hunter i am fisherman");
        }

        public static void LaunchFourth()
        {
            var pesho = new Person("Pesho");

            var minister = new Minister("Moon");
            minister.activate("Hello World");
            minister.TrackPerson(pesho);
        }

        public static void LaunchSecond()
        {
            Car bmw = new Car("Bmw", 190, "320", new TuningLevelOne());
            bmw.LevelUp(bmw);
            Car mercedes = new Car("Mercedes", 612, "S63AMG", new TuningLeveTwo());
            mercedes.LevelUp(mercedes);
            Car audi = new Car("Audi", 450, "RS6", new NoTuning());

            Console.WriteLine(bmw);
            Console.WriteLine(mercedes);
            Console.WriteLine(audi);
        }

        public static void LaunchThird()
        {
            Gold gold = new Gold(3500);
            Platinum platinum = new Platinum(3700);
            PriceObserver priceObserver = new PriceObserver();
            TimeObserver ts = new TimeObserver();

            gold.addSubsriber(priceObserver);
            platinum.addSubsriber(priceObserver);

            gold.addSubsriber(ts);
            platinum.addSubsriber(ts);


            gold.PriceUp();
            gold.PriceUp();
            gold.PriceUp();
            platinum.PriceUp();



            randomLogicForStockMarket(gold, platinum);
            gold.RemoveObserver(ts);
            gold.RemoveObserver(priceObserver);

            gold.PriceUp();
            gold.PriceUp();
            gold.PriceUp();

        }

        private static void randomLogicForStockMarket(Gold gold, Platinum pl)
        {
            for (int i = 0; i < 10; i++)
            {
                var random = new Random();
                var number = random.Next(0, 2);
                if (number == 0)
                {
                    gold.PriceUp();
                    pl.PriceUp();
                }
                else
                {
                    gold.PriceDown();
                    pl.PriceDown();
                }
            }
        }
    }
}
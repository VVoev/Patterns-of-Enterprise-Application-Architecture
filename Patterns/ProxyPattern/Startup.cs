using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace ProxyPattern
{
    class Startup
    {
        static void Main(string[] args)
        {
            // FirstDemo();

           //SecondDemo();
        }

        private static void SecondDemo()
        {
            var machine = new CofeeMachine();
            machine.InsertPassword("9999");
            var coffesSold = machine.GetCurrentCoffesForToday();
            Console.WriteLine(coffesSold);

            machine.UnPlugForFold();

            var proxy = new MachineProxy();

            proxy.InsertPassword("9999");
            var proxysold = proxy.GetCurrentCoffesForToday();
            Console.WriteLine(proxysold);
        }
    }


    #region FirstDemo
    class ActualPricesProxy : IActualPrices
    {
        public string GoldPrice
        {
            get
            {
                return GetResponseFromServer("g");
            }
        }

        public string SilverPrice
        {
            get
            {
                return GetResponseFromServer("s");
            }
        }

        public string DollarToRupee
        {
            get
            {
                return GetResponseFromServer("d");
            }
        }

        private string GetResponseFromServer(string input)
        {
            string result = string.Empty;
            using (TcpClient client = new TcpClient())
            {
                client.Connect("127.0.0.1", 9999);

                Stream stream = client.GetStream();

                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(input.ToCharArray());

                stream.Write(ba, 0, ba.Length);

                byte[] br = new byte[100];
                int k = stream.Read(br, 0, 100);



                for (int i = 0; i < k; i++)
                {
                    result += Convert.ToChar(br[i]);
                }

                client.Close();
            }
            return result;
        }
    }

    interface IActualPrices
    {
        string GoldPrice
        {
            get;
        }

        string SilverPrice
        {
            get;
        }

        string DollarToRupee
        {
            get;
        }
    }

    class ActualPrices : IActualPrices
    {
        public string GoldPrice
        {
            get
            {
                // This value should come from a DB typically
                return "100";
            }
        }

        public string SilverPrice
        {
            get
            {
                // This value should come from a DB typically
                return "5";
            }
        }

        public string DollarToRupee
        {
            get
            {
                // This value should come from a DB typically
                return "50";
            }
        }
    }
    #endregion

    #region SecondDemo
    public class MachineProxy : ICofeeMAchine, ICofeeState
    {
        private CofeeMachine cm = new CofeeMachine();
        public string currentState()
        {
            return cm.currentState();
        }

        public int GetCurrentCoffesForToday()
        {
            return cm.GetCurrentCoffesForToday();
        }

        public void InsertPassword(string password)
        {
            cm.InsertPassword(password);
        }

        public void PluginIntoVold()
        {
            cm.PluginIntoVold();
        }

        public void UnPlugForFold()
        {
            cm.UnPlugForFold();

        }
    }



    public interface ICofeeMAchine
    {
        string currentState();
        int GetCurrentCoffesForToday();
    }

    public interface ICofeeState
    {
        void PluginIntoVold();
        void UnPlugForFold();
        void InsertPassword(string password);
    }

    public class CofeeMachine : ICofeeMAchine, ICofeeState
    {
        private string state = "Off";
        private string cofeePassword = "9999";

        public CofeeMachine()
        {

        }

        public string currentState()
        {
            return this.state;
        }

        public int GetCurrentCoffesForToday()
        {
            return 150;
        }

        public void InsertPassword(string password)
        {
            if (password == this.cofeePassword)
            {
                Console.WriteLine("Machine is On");
                this.state = "On";
            }
            else
            {
                throw new Exception("Wrong Password");
            }
        }

        public void PluginIntoVold()
        {
            this.state = "On";
            Console.WriteLine("Machine is On");
        }

        public void UnPlugForFold()
        {
            this.state = "Off";
            Console.WriteLine("Machine is Off");
        }
    }
    #endregion
}

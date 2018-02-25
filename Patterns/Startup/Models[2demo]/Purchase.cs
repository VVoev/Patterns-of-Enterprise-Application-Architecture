namespace Startup.Models_2demo_
{
    /// <summary>
    /// Class holding request details
    /// </summary>
    public class Purchase
    {
        public Purchase(int number, double amount)
        {
            this.Number = number;
            this.Amount = amount;
        }

        public int Number { get; set; }
        public double Amount { get; set; }
    }
}

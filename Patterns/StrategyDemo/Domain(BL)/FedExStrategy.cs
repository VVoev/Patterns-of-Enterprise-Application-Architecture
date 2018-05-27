using StrategyDemo.Domain_BL_;

namespace StrategyDemo.Test
{
    public class FedExStrategy : IShippingCostStrategy
    {
        public FedExStrategy()
        {
        }

        public double Calculate(Order order)
        {
            return 5.00d;
        }
    }
}
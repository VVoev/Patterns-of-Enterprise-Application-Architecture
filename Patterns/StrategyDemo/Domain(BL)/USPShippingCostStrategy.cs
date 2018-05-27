using StrategyDemo.Domain_BL_;

namespace StrategyDemo.Test
{
    public class USPShippingCostStrategy : IShippingCostStrategy
    {
        public double Calculate(Order order)
        {
            return 3.00;
        }
    }
}
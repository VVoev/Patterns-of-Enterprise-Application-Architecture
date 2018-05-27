namespace StrategyDemo.Domain_BL_
{
    public class ShippingCostCalculatorService
    {
        readonly IShippingCostStrategy shipingCostStrategy;

        public ShippingCostCalculatorService(IShippingCostStrategy shipingCostStrategy)
        {
            this.shipingCostStrategy = shipingCostStrategy;
        }

        public double CalculateShippingCost(Order order)
        {
            return shipingCostStrategy.Calculate(order);
        }
    }
}

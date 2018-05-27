namespace StrategyDemo.Domain_BL_
{
    public interface IShippingCostStrategy
    {
        double Calculate(Order order);
    }
}

namespace DecoratorDemo.Models_1demo_
{
    public class ChiliSauce : PizzaDecorator
    {
        public ChiliSauce(Pizza pizza) : base(pizza)
        {
            Description = "Chili Sauce";
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 1.00;
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + Description;
        }
    }
}

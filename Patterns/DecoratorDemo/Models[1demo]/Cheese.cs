namespace DecoratorDemo.Models_1demo_
{
    public class Cheese : PizzaDecorator
    {
        public Cheese(Pizza pizza) : base(pizza)
        {
            Description = "Cheese";
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 1.50;
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + Description;
        }
    }

}

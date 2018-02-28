namespace DecoratorDemo.Models_1demo_
{
    public class Pepperenni : PizzaDecorator
    {
        public Pepperenni(Pizza pizza) : base(pizza)
        {
            Description = "Peperroni";
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 0.50;
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + Description;
        }
    }

}

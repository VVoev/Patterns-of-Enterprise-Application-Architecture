namespace DecoratorDemo.Models_1demo_
{
    public class CreamySauce : PizzaDecorator
    {
        public CreamySauce(Pizza pizza) : base(pizza)
        {
            Description = " Creamy Sauce";
        }

        public override double CalculateCost()
        {
            return this._pizza.CalculateCost() + 0.50;
        }

        public override string GetDescription()
        {
            return this._pizza.GetDescription() + Description;
        }
    }
}

namespace DecoratorDemo.Models_1demo_
{
    public class LargePizza : Pizza
    {
        public LargePizza()
        {
            Description = "Large Pizza";
        }
        public override double CalculateCost()
        {
            return 10.20;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }

}

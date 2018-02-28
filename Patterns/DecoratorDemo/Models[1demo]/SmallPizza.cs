namespace DecoratorDemo.Models_1demo_
{
    public class SmallPizza : Pizza
    {

        public SmallPizza()
        {
            Description = "Small Pizza";
        }
        public override double CalculateCost()
        {
            return 5.60;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }

}

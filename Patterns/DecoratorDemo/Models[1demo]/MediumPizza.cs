namespace DecoratorDemo.Models_1demo_
{
    public class MediumPizza : Pizza
    {
        public MediumPizza()
        {
            Description = "Medium Pizza";
        }
        public override double CalculateCost()
        {
            return 7.40;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }

}

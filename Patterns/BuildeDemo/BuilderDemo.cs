using Builder;
using Builder.Builders;
using Builder.Directors;

namespace BuildeDemo
{
    public static class BuilderDemo
    {
        public static void FirstDemo()
        {
            var maker1 = new SandwithcMaker(new MySandwitchBuilder());
            maker1.MakeSandwitch();
            var sandwitch1 = maker1.getSandwitch();

            var maker2 = new SandwithcMaker(new ClubSandwitchBuilder());
            maker2.MakeSandwitch();
            var sandwitch2 = maker2.getSandwitch();


            sandwitch1.Display();
            sandwitch2.Display();
        }

        public static void SecondDemo()
        {
            VehicleConstructor constructor = new VehicleConstructor();

            // And we can choose concrete builder
            VehicleBuilder builder = new ScooterBuilder();
            constructor.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            constructor.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            constructor.Construct(builder);
            builder.Vehicle.Show();
        }
    }
}

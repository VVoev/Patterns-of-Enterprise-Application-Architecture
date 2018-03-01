using System.Collections.Generic;

namespace BuildeDemo
{
    public class ClubSandwitchBuilder : SandwitchBuilder
    {
        public override void AddVegeTables()
        {
            sandwitch.vegatables = new List<string>() { "Tomato", "Cucumber" };
        }

        public override void PutSauces()
        {
            sandwitch.hasMayo = true;
            sandwitch.hasMustard = false;
        }

        public override void PrepareMeatAndCheese()
        {
            sandwitch.cheeseType = CheeseType.Yellow;
            sandwitch.meatType = MeatType.Pork;
        }

        public override void PrepareBread()
        {
            sandwitch.breadType = BreadType.Wholegrain;
            sandwitch.isToasted = true;
        }
    }

}

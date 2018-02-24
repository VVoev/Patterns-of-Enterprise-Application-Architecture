using System.Collections.Generic;

namespace BuildeDemo
{
    public class MySandwitchBuilder : SandwitchBuilder
    {
  
        public override void AddVegeTables()
        {
            sandwitch.vegatables = new List<string>() { "Tomato", "Letice" };
        }

        public override void  PutSauces()
        {
            sandwitch.hasMayo = false;
            sandwitch.hasMustard = true;
        }

        public override void PrepareMeatAndCheese()
        {
            sandwitch.cheeseType = CheeseType.Swiss;
            sandwitch.meatType = MeatType.Turkey;
        }

        public override void PrepareBread()
        {
            sandwitch.breadType = BreadType.Wheat;
            sandwitch.isToasted = true;
        }
    }

}

namespace BuildeDemo
{
    public class SandwithcMaker
    {
        private readonly SandwitchBuilder builder;

        public SandwithcMaker(SandwitchBuilder builder)
        {
            this.builder = builder;
        }

        public void MakeSandwitch()
        {
            builder.CreateSandwitch();
            builder.PrepareBread();
            builder.PrepareMeatAndCheese();
            builder.PutSauces();
            builder.AddVegeTables();
        }

        public Sandwich getSandwitch()
        {
            return builder.getSandwitch();
        }


    }

}

namespace BuildeDemo
{
    public abstract class SandwitchBuilder
    {
        protected Sandwich sandwitch;
        public Sandwich getSandwitch()
        {
            return sandwitch;
        }

        public void CreateSandwitch()
        {
            sandwitch = new Sandwich();
        }

        public abstract void PrepareBread();
        public abstract void PrepareMeatAndCheese();
        public abstract void PutSauces();
        public abstract void AddVegeTables();
    }

}

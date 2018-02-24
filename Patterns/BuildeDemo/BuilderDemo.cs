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
    }
}

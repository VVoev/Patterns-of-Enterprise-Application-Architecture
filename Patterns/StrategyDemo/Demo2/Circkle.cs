namespace StrategyDemo.Demo2
{
    class CirckleStrategy : IShape
    {
        public int Radius
        {
            get
            {
                return 4;
            }
        }

        public double CalculateSurface()
        {
            return this.Radius * 5;
        }
    }
}

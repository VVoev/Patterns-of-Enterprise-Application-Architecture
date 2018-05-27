namespace StrategyDemo.Demo2
{
    class TriangleStrategy : IShape
    {
        public double CalculateSurface()
        {
            var result = 3 *  this.Radius;
            return result;

        }


        public int Radius
        {
            get
            {
                return 5;
            }
        }
    }
}

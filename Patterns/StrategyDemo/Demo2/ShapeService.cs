namespace StrategyDemo.Demo2
{
    class ShapeService
    {
        private readonly IShape shape;

        public ShapeService(IShape shape)
        {
            this.shape = shape;
        }

        public double Calculate()
        {
            return shape.CalculateSurface();
        }
    }
}

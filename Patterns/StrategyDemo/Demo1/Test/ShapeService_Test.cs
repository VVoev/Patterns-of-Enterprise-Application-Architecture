using NUnit.Framework;
using StrategyDemo.Demo2;

namespace StrategyDemo.Demo1.Test
{
    class ShapeService_Test
    {

        [Test]
        public void CalculateTriangleSurface()
        {
            var shapeService = new ShapeService(new TriangleStrategy());
            var result = shapeService.Calculate();
            Assert.AreEqual(15, result);
        }

        [Test]
        public void CalculateCirckleSurface()
        {
            var shapeService = new ShapeService(new CirckleStrategy());
            var result = shapeService.Calculate();
            Assert.AreEqual(20, result);

        }


    }
}

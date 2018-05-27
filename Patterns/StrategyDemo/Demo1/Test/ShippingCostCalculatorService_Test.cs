using NUnit.Framework;
using StrategyDemo.Domain_BL_;

namespace StrategyDemo.Test
{
    class ShippingCostCalculatorService_Test
    {
        [Test]
        public void When_shipping_via_UPS_the_cost_is_425()
        {
            var strategy = new UPSShippingCostStrategy();
            var shippingCalculatorService = new ShippingCostCalculatorService(strategy);
            var order = new Order();
            //var order = Mother.CreateOrder_UPS();
            var cost = shippingCalculatorService.CalculateShippingCost(order);
            Assert.AreEqual(4.25,cost);
            Assert.AreEqual(2, order.Id);
        }

        [Test]
        public void When_shipping_via_USPS_the_cost_is_300()
        {
            var strategy = new USPShippingCostStrategy();
            var shippingCalculatorService = new ShippingCostCalculatorService(strategy);
            var order = new Order();
            //var order = Mother.CreateOrder_UPS();
            var cost = shippingCalculatorService.CalculateShippingCost(order);
            Assert.AreEqual(3.00, cost);
            Assert.AreEqual(3, order.Id);

        }

        [Test]
        public void When_shipping_via_FedEx_the_cost_is_500()
        {
            var strategy = new FedExStrategy();
            var shippingCalculatorService = new ShippingCostCalculatorService(strategy);
            var order = new Order();
            //var order = Mother.CreateOrder_UPS();
            var cost = shippingCalculatorService.CalculateShippingCost(order);
            Assert.AreEqual(5.00, cost);
            Assert.AreEqual(1, order.Id);

        }
    }
}

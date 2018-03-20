namespace LazyLoadingDemo.VirtualProxy
{
    using System;
    using System.Collections.Generic;


    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }

        public IEnumerable<IOrder> Orders
        {
            get { return ProxyOrders; }
        }

        protected IEnumerable<OrderVirtualProxy> ProxyOrders
        {
            get { return OrdersDatabase.GetProxyOrders(CustomerID); }
        }

        public Customer(int id, string name)
        {
            CustomerID = id;
            Name = name;
        }
    }

    public interface IOrder
    {
        void DisplayOrder();
    }

    public class Order : IOrder
    {
        public int OrderID { get; set; }
        public string Description { get; set; }
        public DateTime SubmissionDate { get; set; }
        public DateTime? ShipmentDate { get; set; }

        //Constructor
        public Order()
        {
            LoadOrder();
        }

        public void LoadOrder()
        {
            Console.WriteLine("Loading order from database...");
        }

        public void DisplayOrder()
        {
            Console.WriteLine("Displaying order \n" +
                              "Description: {0}\n" +
                              "SubmissionDate: {1}\n" +
                              "ShipmentDate: {2}\n", Description, SubmissionDate, ShipmentDate);
        }
    }

    public static class OrdersDatabase
    {
        public static IOrder GetOrder()
        {
            return new Order();
        }

        public static IEnumerable<Order> GetOrders(object customerID)
        {
            return GetOrders((int)customerID);
        }

        public static IEnumerable<Order> GetOrders(int customerID)
        {
            return new List<Order>();
        }

        public static IEnumerable<OrderVirtualProxy> GetProxyOrders(int customerID)
        {
            return new List<OrderVirtualProxy>();
        }
    }

    public class OrderVirtualProxy : IOrder
    {
        public string Description { get; set; }
        public DateTime SubmissionDate { get; set; }
        public DateTime? ShipmentDate { get; set; }

        private IOrder _realOrder;

        public void DisplayOrder()
        {
            if (_realOrder == null)
            {
                _realOrder = new Order(); // The order gets filled
            }

            Console.WriteLine("Displaying order\n" +
                              "Description: {0}\n" +
                              "SubmissionDate: {1}\n" +
                              "ShipmentDate: {2}\n", Description, SubmissionDate, ShipmentDate);
        }
    }
}

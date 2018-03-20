using System;
using System.Collections.Generic;

namespace LazyLoadingDemo
{
    class Startup
    {
        static void Main(string[] args)
        {
            /// 1 ///
            LazyLoadingHeavyOperation();

            /// 2 ///
            ProxyLazyLoading();


            /// 3 ///
            Customer cust = new Customer(1, "MyCustomer");
            foreach (var order in cust.Orders)
            {
                order.DisplayOrder();
            }

            /// 4 ///
            Customer customer = new Customer(19373, "MyCustomer");

            foreach (Order order in customer.Orders)
            {
                // Do Something With "Ghost" Orders
            }



        }

        private static void LazyLoadingHeavyOperation()
        {
            var lazyFactoryObject = new LazyFactoryObject();
            var list = lazyFactoryObject.GetLazyFactoryObject(LazyObjectType.Big);
            Console.WriteLine(list.Result.Count);

            Console.WriteLine(new string('-', 60));
        }

        private static void ProxyLazyLoading()
        {
            Console.WriteLine(new string('-', 60));
            var db = new DataContext();
            var user = db.GetUserById(1337);
            Console.WriteLine(user.Roles.Count);
            Console.WriteLine(user.Id);
        }
    }
    /// 1 ///
    public enum LazyObjectType
    {
        None,
        Small,
        Big,
        Bigger,
        Huge
    }
    public struct LazyObject
    {
        public LazyObjectType Name;
        public IList<int> Result;
    }
    public class LazyFactoryObject
    {
        // internal collection of items
        // IDictionary makes sure they are unique
        private readonly IDictionary<LazyObjectType, LazyObject> lazyObjectList = new Dictionary<LazyObjectType, LazyObject>();

        public LazyObject GetLazyFactoryObject(LazyObjectType name)
        {
            LazyObject noGoodSomeOne;

            // retrieves LazyObjectType from list via out, else creates one and adds it to list
            if (!this.lazyObjectList.TryGetValue(name, out noGoodSomeOne))
            {
                noGoodSomeOne = new LazyObject { Name = name, Result = this.Result(name) };

                this.lazyObjectList.Add(name, noGoodSomeOne);
            }

            return noGoodSomeOne;
        }

        // takes type and create 'expensive' list
        private IList<int> Result(LazyObjectType name)
        {
            IList<int> result;

            switch (name)
            {
                case LazyObjectType.Small:
                    result = this.CreateSomeExpensiveList(1, 100);
                    break;
                case LazyObjectType.Big:
                    result = this.CreateSomeExpensiveList(1, 1000);
                    break;
                case LazyObjectType.Bigger:
                    result = this.CreateSomeExpensiveList(1, 10000);
                    break;
                case LazyObjectType.Huge:
                    result = this.CreateSomeExpensiveList(1, 100000);
                    break;
                case LazyObjectType.None:
                    result = null;
                    break;
                default:
                    result = null;
                    break;
            }

            return result;
        }

        // not an expensive item to create, but you get the point
        // delays creation of some expensive object until needed
        private IList<int> CreateSomeExpensiveList(int start, int end)
        {
            IList<int> result = new List<int>();

            for (int counter = 0; counter < (end - start); counter++)
            {
                result.Add(start + counter);
            }

            return result;
        }
    }

    /// 2 ///
    public class DataContext
    {
        public User GetUserById(int id)
        {
            return new UserProxy
            {
                Id = id,
            };
        }
    }
    public class User
    {
        public int Id { get; set; }

        public virtual List<string> Roles { get; set; }
    }
    public class UserProxy : User
    {
        public override List<string> Roles
        {
            get
            {
                if (base.Roles == null)
                {
                    // Get the values from the database
                    // Here is the lazy loading
                    base.Roles = new List<string> { "Admin" };
                }

                return base.Roles;
            }

            set
            {
                base.Roles = value;
            }
        }

        public override bool Equals(object obj)
        {
            var other = obj as User;
            if (other == null)
            {
                return false;
            }

            return other.Id == this.Id;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }

    /// 4 ///
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        private IEnumerable<Order> _orders;

        public IEnumerable<Order> Orders
        {
            get
            {
                if (_orders == null)
                {
                    _orders = OrdersDatabase.GetOrders(CustomerID);
                }
                return _orders;
            }
        }

        // Constructor
        public Customer(int id, string name)
        {
            CustomerID = id;
            Name = name;
        }
    }
    public class Order
    {
        public int OrderID { get; set; }
        private string _description;
        private DateTime _submissionDate;
        private DateTime? _shipmentDate;

        public string Description
        {
            get
            {
                LoadOrderDescription();
                return _description;
            }
            set { _description = value; }
        }

        public DateTime SubmissionDate
        {
            get
            {
                LoadOrderDetails();
                return _submissionDate;
            }
            set { _submissionDate = value; }
        }

        public DateTime? ShipmentDate
        {
            get
            {
                LoadOrderDetails();
                return _shipmentDate;
            }
            set { _shipmentDate = value; }
        }

        // Constructor
        public Order()
        {
            LoadPartialOrder();
        }

        public void LoadPartialOrder()
        {
            Console.WriteLine("Loading order ID from database...");
        }

        public void DisplayOrder()
        {
            Console.WriteLine("Displaying order \n" +
                              "Description: {0}\n" +
                              "SubmissionDate: {1}\n" +
                              "ShipmentDate: {2}\n", Description, SubmissionDate, ShipmentDate);
        }

        public void LoadOrderDescription()
        {
            // Fill "_description" field
        }

        public void LoadOrderDetails()
        {
            // Fill "_submissionDate" and "_shipmentDate" fields
        }
    }
    public static class OrdersDatabase
    {
        public static IEnumerable<Order> GetOrders(object customerID)
        {
            return GetOrders((int)customerID);
        }

        public static IEnumerable<Order> GetOrders(int customerID)
        {
            return new List<Order>();
        }
    }
}


using System.Collections.Generic;
using System.Linq;

namespace OrganizingData
{
    public class ReplaceDataValueWithObject
    {
        public class Order
        {
            private readonly string customer;

            public Order(string customer)
            {
                this.customer = customer;
            }

            public string Customer
            {
                get { return customer; }
            }

            public static int NumberOfOrdersFor(IEnumerable<Order> orders, string customer)
            {
                return orders.Where(o => o.Customer == customer).Count();
            }
        }
    }
}
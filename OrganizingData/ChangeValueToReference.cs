using System.Collections.Generic;
using System.Linq;

namespace OrganizingData
{
    public class ChangeValueToReference
    {
        public class Order
        {
            private readonly Customer customer;

            public Order(string customer)
            {
                this.customer = new Customer(customer);
            }

            public static int NumberOfOrdersFor(IEnumerable<Order> orders, string customer)
            {
                return orders.Where(o => o.customer.CustomerName == customer).Count();
            }
        }

        public class Customer
        {
            private readonly string customerName;

            public Customer(string customerName)
            {
                this.customerName = customerName;
            }

            public string CustomerName
            {
                get { return customerName; }
            }
        }
    }
}
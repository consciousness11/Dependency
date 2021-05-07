using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency
{
    class Order
    {
        public Int32 OrderId { get; set; }
        public Guid OrderCustomer { get; set; }
        public DateTime OrderDateTime { get; set; }

        public Order(Customer customer)
        {
            this.OrderCustomer = customer.CustomerId;   
        }

        public void display()
        {
            Console.WriteLine(this.OrderCustomer);
        }
    }
}

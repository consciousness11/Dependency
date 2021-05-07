using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency
{
    class Customer
    {
        public Guid CustomerId { get; set; }
        public String CustomerName { get; set; }

        public Customer()
        {
           this.CustomerId = new Guid();
           
        }
        public void display()
        {
            Console.WriteLine(this.CustomerId);
        }
    }
}

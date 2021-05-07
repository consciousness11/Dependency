using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cs = new Customer();

            cs.display();

            Order or = new Order(cs);

            or.display();

            Console.Read();

        }
    }
}

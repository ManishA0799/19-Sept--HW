using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class__Rectangle_HW
{
    internal class Program
    {
        static void ain(string[] args)
        {
            IOrder order = new Transaction();
            Console.WriteLine(order.DisplayDetails());

            ICustomer customer = new Transaction();
            Console.WriteLine(customer.DisplayDetails());

        }
    }
}

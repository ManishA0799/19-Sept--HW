using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class__Rectangle_HW
{
    public interface IOrder
    {
        string DisplayDetails();
    }
    public interface ICustomer
    {
        string DisplayDetails();
    }

    public class Transaction : IOrder, ICustomer
    {
        string IOrder.DisplayDetails()
        {
            return "Order details";
        }

        string ICustomer.DisplayDetails()
        {
            return "Customer details";
        }
    }


}

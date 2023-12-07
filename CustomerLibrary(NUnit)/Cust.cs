using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibrary
{
    public enum CustType
    {
        Basic,
        Premium,
        Special
    }
    public class Cust
    {
        public int CustID { get; set; }
        public string CustName { get; set; }
        public CustType CustomerType { get; set; }


    }

    public class Order
    {
        public int OrderId { get; set; }
        public int ProductID { get; set; }
        public int Qty { get; set; }
        public decimal Amount { get; set; }

    }

    public class CustomerOrderService
    {
        public void ApplyDiscount(Cust customer, Order order)
        {
            if (customer.CustomerType == CustType.Premium)
            {
                order.Amount = order.Amount - ((order.Amount * 10) / 100);
            }
            else if (customer.CustomerType == CustType.Special)
            {
                order.Amount = order.Amount - ((order.Amount * 20) / 100);
            }
        }

    }
}

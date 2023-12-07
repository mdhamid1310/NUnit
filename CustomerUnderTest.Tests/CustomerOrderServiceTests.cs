using CustomerLibrary;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUnderTest.Tests
{
    [TestFixture]//it allows you to write  tests under it
    public class CustomerOrderServiceTests
    {
        [TestCase]
        public void When_Premium_Customer_Expect_10PercentDiscount()
        {
            //Arrange
            Cust c = new Cust { CustID = 1, CustName = "Gauri", CustomerType = CustType.Premium };
            Order o = new Order { OrderId = 1, ProductID = 11, Qty = 100, Amount = 150 };
            CustomerOrderService cs = new CustomerOrderService();
            //Act
            cs.ApplyDiscount(c, o);
            //Assert

            ClassicAssert.AreEqual(o.Amount, 135);

        }
    }
}

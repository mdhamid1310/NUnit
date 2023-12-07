using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerLibrary_NUnit_;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace CustomerUnderTest.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
            public void Test1()
        {
            Assert.That(1 ==1);
        }


        [Test] 
        public void TestAcceptData() 
        {
            Product p=new Product();

            p.ProductID = 1;
            p.ProductName = "Test";
            p.Price = 10;


            //Act

            Product p1 = new Product();
            p1.AcceptData(1, "Test", 10);

            ClassicAssert.AreEqual(p.ProductID, p1.ProductID);

            ClassicAssert.AreEqual(p.ProductName, p1.ProductName);

            ClassicAssert.AreEqual(p.Price, p1.Price);
        }
    }
}

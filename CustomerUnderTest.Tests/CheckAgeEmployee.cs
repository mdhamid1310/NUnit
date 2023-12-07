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
    [TestFixture]
    public class CheckAgeEmployee
    {
        [TestCase(50)]
        [TestCase(30)]
        [TestCase(18)]
        public void WhenAdult_IsTrue(int age)
        {
            Emp emp = new Emp();
            emp.Age = age;

            bool result = emp.IsAdult();

            Assert.That(result == true);


            //Emp e=new Emp();
            //            e.Age = 20;

            //            bool result = e.IsAdult();
            //            ClassicAssert.That(result == true);
        }
    }
}
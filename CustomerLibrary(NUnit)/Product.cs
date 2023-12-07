using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibrary_NUnit_
{
    public class Product

    {
        public int ProductID { get; set; }
        public string ProductName {  get; set; }

        public int Price { get; set; }

        public void AcceptData(int pid,string pname,int cost)
        {
            ProductID = pid;
            ProductName = pname;
            Price = cost;
        }
    }
}

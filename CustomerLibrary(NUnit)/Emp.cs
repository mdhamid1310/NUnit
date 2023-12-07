using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibrary
{
    public class Emp
    {
        public int Empid { get; set; }
        public int Age { get; set; }
        public bool IsAdult()
        {
            if (Age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
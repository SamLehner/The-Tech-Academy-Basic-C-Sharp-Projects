using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_Project
{
   public class Math
    {
        // A method using two variables with one optional incase user does not inpute a value
        public int Addition(int a, int b = 10)
        {
            int total = (a + b) * 2;
            return total;
        }
    }
}

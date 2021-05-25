using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_App
{
    public class Math
    {
        /// <summary>
        /// Method for taking an integer value and adding 30 to it
        /// </summary>
        /// <param name="a">User input int</param>
        /// <returns>int value</returns>
        public int Addition(int a)
        {
            int total = a + 30;
            return total;
        }
        // Same as the top one but using decimal
        public int Addition(decimal b)
        {
            decimal total = b + 25;
            int convertedTotal = Convert.ToInt32(total);
            return convertedTotal;
        }
        // Same as before but using a string
        public int Addition(string c)
        {
            
            int total = Convert.ToInt32(c) + 20;
            return total;
        }
    }
}

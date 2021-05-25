using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Method_Project
{
    static class Math
    {
        public static void Division(int a)
        {
            int total = a / 2;
            Console.WriteLine(total);
        }

        public static void Division(int a, int b, out int c)
        {
            c = a / b;
            
        }
    }
}

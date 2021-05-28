using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DateTime.Now);

            Console.WriteLine("What is your favorite number?");
            int answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DateTime.Now.AddHours(answer));
            Console.ReadLine();
        }
    }
}

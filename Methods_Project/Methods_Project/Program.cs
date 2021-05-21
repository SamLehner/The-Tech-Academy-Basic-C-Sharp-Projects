using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the class for later
            Math math = new Math();
            // Asking the user for an input
            Console.WriteLine("What number do you want changed by 25? ");
            int answer = Convert.ToInt32(Console.ReadLine());

            // Calling each method and passing the variable the user gives us to do math opertaions.
            Console.WriteLine(math.Addition(answer));
            Console.WriteLine(math.Multiply(answer));
            Console.WriteLine(math.Division(answer));
            Console.ReadLine();
        }
    }
}

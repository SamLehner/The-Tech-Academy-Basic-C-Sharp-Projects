using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Method_App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instaniating the method
            Math math = new Math();

            // Getting user inputs and converting to int
            Console.WriteLine("Please enter a number");
            int answer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter another number");
            int answer2 = Convert.ToInt32(Console.ReadLine());


            // Calling our method using parameter names
            math.Addition(a: answer, b: answer2);
            Console.ReadLine();
        }
    }
}

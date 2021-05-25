using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the class of math in the main program
            Math math = new Math();

            //Asking for user input to do opertioans on
            Console.WriteLine("What is your favorite number?");
            int answer = Convert.ToInt32(Console.ReadLine());

            // Calling the method Addition using an int value
            Console.WriteLine(math.Addition(answer));
            Console.ReadLine();

            // Asking user for decimal value
            Console.WriteLine("What is your favorite decimal number?");
            decimal deciAnswer = Convert.ToDecimal(Console.ReadLine());

            // Calling a mehtod with the same name but passing in a decimal
            Console.WriteLine(math.Addition(deciAnswer));
            Console.ReadLine();

            Console.WriteLine("What is your favorite number?");
            string stringAnswer = Console.ReadLine();

            // Calling a method with the same name but passing in a string value.
            Console.WriteLine(math.Addition(stringAnswer));
            Console.ReadLine();




        }
    }
}

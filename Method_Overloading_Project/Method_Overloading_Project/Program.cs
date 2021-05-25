using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of our method
            Math math = new Math();
            int varAnswer = 0;

            // Asking for user input for variables
            Console.WriteLine("Please enter a random number!");
            int answer = Convert.ToInt32(Console.ReadLine());

            // Checking if the user has inputted a number, if not we use the optional value.
            Console.WriteLine("Enter another number only if you want to!");
            string answer2 = Console.ReadLine();
            if (!string.IsNullOrEmpty(answer2))
            {
                varAnswer = Convert.ToInt32(answer2);
                Console.WriteLine(math.Addition(answer, varAnswer));
            }
            else
            {
                Console.WriteLine(math.Addition(answer));
            }

            Console.ReadLine();
            


        }
    }
}

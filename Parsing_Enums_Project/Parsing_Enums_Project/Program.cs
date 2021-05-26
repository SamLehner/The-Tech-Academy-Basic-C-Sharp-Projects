using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Puting code into a try block to catch user input errors
            try
            {
                // Asking the user to enter the day of the week
                    Console.WriteLine("Please enter the day of the week! ");
                string answer = Console.ReadLine();

                // Parsing the enum to convert our user entered string to our enum values
                Weekday answer1 = (Weekday)Enum.Parse(typeof(Weekday), answer);
                Console.WriteLine(answer1);
            }
            // If user doesnt enter an enum it will send this meesage
            catch
            {
                Console.WriteLine("Please enter a day of the week! ");
            }
            

            
            Console.ReadLine();

        }
    }
}

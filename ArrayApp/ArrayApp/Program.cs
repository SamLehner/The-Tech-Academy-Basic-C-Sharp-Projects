using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApp
{
    class Program
    {
        static void Main()
        {
            // Making a string array for a user to pick an index value from
            string[] strArray = { "Hello", "happy", "new", "customer!", "Enjoy your stay!" };
            Console.WriteLine("Please pick a number between \"0\" and \"4\"!");
            // Taking the string value form the user and converting it to an integer
            int pick1 = Convert.ToInt32(Console.ReadLine());
            // Adding a message if the user doesnt pick a value within the range of the array
            if (pick1 > strArray.Length || pick1 < 0)
            {
                Console.WriteLine("You have selected a number not within the range of the array.");
            }
            // If they picked a number within the values of the array it will show the selected value
            else 
            { 
                Console.WriteLine(strArray[pick1]);
            }
            Console.ReadLine();

            // Making an integer array for a user to pick a value from
            int[] intArray = { 10, 20, 30, 40, 50, 60 };
            Console.WriteLine("Please pick a number between \"0\" and \"5\"!");
            // Converting the string value to an integer
            int pick2 = Convert.ToInt32(Console.ReadLine());
            // Adding message incase user selects number outside the range of the array
            if (pick2 > intArray.Length || pick2 < 0)
            {
                Console.WriteLine("You have selected a number not within the range of the array.");
            }
            else
            {
                Console.WriteLine(intArray[pick2]);
            }
            Console.ReadLine();

            // Creating a list of strings and populating it
            List<string> strList = new List<string>();
            strList.Add("Hello");
            strList.Add("Person");
            strList.Add("How");
            strList.Add("Are");
            strList.Add("You");

            // Asking the user to select a index value for the string
            Console.WriteLine("Please pick a number between \"0\" and \"4\"!");
            // Converting the string to integer to return the value in the selected index
            int pick3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(strList[pick3]);
            Console.ReadLine();
        }
    }
}

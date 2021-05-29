using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a constant
            const string proName = "Bass Pro Shop! ";
            Console.WriteLine("Welcome to {0}", proName);

            // Using variables using var
            var howAreYou = "How are you?";
            Console.WriteLine(howAreYou);
            string answer = Console.ReadLine();
            var name = "What is your name?";
            Console.WriteLine(name);
            string answer2 = Console.ReadLine();

            // Creating a person object and passing in the name they give, if no wellness check is types the default will appear
            Person person = new Person(answer2);
            Console.WriteLine(person.Name + person.Wellness);

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asling user for input in our program
            Console.WriteLine("What is the best number in the universe? ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool universeNum = number == 72;
            

            // A do while loop to make sure the loop is ran once even if 72 is guessed. 
            do
            {
                // Adding switch cases for different numbers the user can input
                switch (number)
                {
                    case 68:
                        Console.WriteLine("You guessed 68: Try again.");
                        Console.WriteLine("Guess a different number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 26. Try again.");
                        Console.WriteLine("Guess a different number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 44:
                        Console.WriteLine("You guessed 44. Try again");
                        Console.WriteLine("Guess a different number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 72:
                        Console.WriteLine("You guessed the number 72. That is correct!");
                        universeNum = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a different number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            // A while loop to show a message when finsing the right number
            while (universeNum == false);
            {
                Console.WriteLine("Congrats on finding the best number in the universe! ");
            }

           
            Console.ReadLine();

        }
    }
}

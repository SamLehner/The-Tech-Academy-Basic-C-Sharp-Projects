using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Program
{
    class Program
    {
        static void Main()
        {
            // Getting input from user to multiply number by 50
            Console.WriteLine("What is your favorite number? ");
            string myNum = Console.ReadLine();
            // Converting string input to int
            int my_Num = Convert.ToInt32(myNum);
            // Multiplying number by 50
            int total = my_Num * 50;
            Console.WriteLine("Your favorite number multiplyed by 50 = " + total);
            Console.ReadLine();

            // Getting input from user to add 25 to the number
            Console.WriteLine("What is the worst number you can think of? ");
            string worstNumber = Console.ReadLine();
            int worst_Number = Convert.ToInt32(worstNumber);
            int remain = worst_Number + 25;
            Console.WriteLine("The worst number you can think of plus 25 = " + remain);

            // Gets input from user to divide by 12.5 and give the return
            Console.WriteLine("Give me a random number. ");
            string randomNumber = Console.ReadLine();
            double random_Number = Convert.ToDouble(randomNumber);
            double quotient = random_Number / 12.5;
            Console.WriteLine("A random number divided by 12.5 = " + quotient);
            Console.ReadLine();

            // Gets input from user to check if it is greater than 50
            Console.WriteLine("Give me a number between 0 and 100. ");
            string num1 = Console.ReadLine();
            int num_1 = Convert.ToInt32(num1);
            bool total2 = num_1 > 50;
            Console.WriteLine("Is your number greater than 50? " + total2);
            Console.ReadLine();

            // Gets input from user to find the remainder and return the result
            Console.WriteLine("Give me one more random number! ");
            string rNum = Console.ReadLine();
            int r_Num = Convert.ToInt32(rNum);
            float total3 = r_Num % 7;
            Console.WriteLine("The remainder of your random number by 7 = " + total3);
            Console.ReadLine();

        }
    }
}

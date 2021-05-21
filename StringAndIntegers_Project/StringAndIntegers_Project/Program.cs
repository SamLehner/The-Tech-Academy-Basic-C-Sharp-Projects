using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndIntegers_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // A try block for out code to help with exception handling
            try
            {
                // Our List of numbers to be divided by the user
            List<int> intList = new List<int>();
            intList.Add(60);
            intList.Add(25); 
            intList.Add(32);
            intList.Add(77); 
            intList.Add(89);
            intList.Add(12);

                // Asking the user to input a number 
            Console.WriteLine("Please enter your favorite number! ");
            int answer = Convert.ToInt32(Console.ReadLine());
            // Our foreach loop to take each int in the list and divide it by the inputed number
            foreach (int i in intList)
            {
                Console.WriteLine(i / answer);
            }
            
            }
            // The catch blocks to handle exceptions
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number! ");
            }
            finally
            {
                Console.ReadLine();
            }
            // Letting us know the try/catch block has been executed
            Console.WriteLine("The program is now out of the try/catch block. ");
            Console.ReadLine();
        }
    }
}

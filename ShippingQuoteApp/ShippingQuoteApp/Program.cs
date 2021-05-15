using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follor the instructions below!");
            Console.ReadLine();

            Console.WriteLine("What is the weight of your package?");
            string packageWeight = Console.ReadLine();
            int packageWeightInt = Convert.ToInt32(packageWeight);
            if (packageWeightInt > 50)
            {
                Console.WriteLine("You're package is too heavy to be shipped via Package Express. Have a good day!");
                Console.ReadLine();
            }
            else
            {




                Console.WriteLine("What is the width of the package you would like shipped?");
                string packageWidth = Console.ReadLine();
                int packageWidthInt = Convert.ToInt32(packageWidth);

                Console.WriteLine("What is the height of the package you would like shipped?");
                string packageHeight = Console.ReadLine();
                int packageHeightInt = Convert.ToInt32(packageHeight);

                Console.WriteLine("What is the length of the package you would like shipped?");
                string packageLength = Console.ReadLine();
                int packageLengthInt = Convert.ToInt32(packageLength);

                if (packageWidthInt + packageHeightInt + packageLengthInt > 50)
                {
                    Console.WriteLine("Your package is too big to be shipped!");
                }
                else
                {
                    Console.WriteLine("Your package is within the limits to be shipped!");
                    int quote = ((packageHeightInt * packageLengthInt * packageWidthInt) / 100);
                    Console.WriteLine("Your estimated total for shipping is: " + quote);
                }
                Console.ReadLine();

            }


                





        }
    }
}

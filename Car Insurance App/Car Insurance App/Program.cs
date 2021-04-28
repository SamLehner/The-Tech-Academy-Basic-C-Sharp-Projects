using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_App
{
    class Program
    {
        static void Main()
        {
            // Asking users age and converting to int
            Console.WriteLine("What is your age? ");
            string myAge = Console.ReadLine();
            int my_Age = Convert.ToInt32(myAge);

            // Getting data from users and converting it to boolean
            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" for Yes and \"false\" for No. ");
            string myDui = Console.ReadLine();
            bool my_Dui = Convert.ToBoolean(myDui);

            // Getting hoe many speeding tickets the user has to see if they are eligible for a liscense 
            Console.WriteLine("How many speeding tickets have you had? ");
            string myTix = Console.ReadLine();
            int my_Tix = Convert.ToInt32(myTix);

            // Seeing if applicants qualify for insurance
            bool qualify = (my_Age > 15 && my_Dui == false && my_Tix <= 3);
            Console.WriteLine("Did you qualify? " + qualify);
            Console.ReadLine();


        }
    }
}

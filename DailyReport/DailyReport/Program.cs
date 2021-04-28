using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            // The Tech Academy title
            Console.WriteLine("The Tech Academy!");

            //Value for name
            Console.WriteLine("What is your name?: ");
            string yourName = Console.ReadLine();
            // Checking if data is stored
            //Console.WriteLine("Your name is:" + yourName);
            //Console.ReadLine();

            // Value for course
            Console.WriteLine("What course are you on?: ");
            string yourCourse = Console.ReadLine();

            //Value for page number converted to int
            Console.WriteLine("What page number are you on?: ");
            string pageNumber = Console.ReadLine();
            int page_Number = Convert.ToInt32(pageNumber);
            //Console.WriteLine("Your number is: " + page_Number);
            //Console.ReadLine();

            // Data for help converted to boolean
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\". ");
            string needHelp = Console.ReadLine();
            bool need_Help = Convert.ToBoolean(needHelp);
            //Console.WriteLine("Your answer is: " + need_Help);
            //Console.ReadLine();

            // Data for experince in the day
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics. ");
            string myExperience = Console.ReadLine();

            // Data for feedback
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific. ");
            string myFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today? ");
            string myHours = Console.ReadLine();
            byte my_Hours = Convert.ToByte(myHours);
            //Console.WriteLine("You studied " + my_Hours + " hours today!");
            //Console.ReadLine();

            //End of program
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();


        }
    }
}

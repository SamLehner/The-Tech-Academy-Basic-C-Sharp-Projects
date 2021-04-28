using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main()
        {
            // Title of our program
            Console.WriteLine("Anonymous Income Comparison Program");

            // Asking person 1 to input their data
            Console.WriteLine("Person 1: How much do you make an hour? ");
            string p1_hourlyRate = Console.ReadLine();
            double p1HourlyRate = Convert.ToDouble(p1_hourlyRate);

            Console.WriteLine("Person 1: How many hours do you work in a week? ");
            string p1_hoursWorked = Console.ReadLine();
            int p1hoursWorked = Convert.ToInt32(p1_hoursWorked);

            // Asking person 2 to input their data
            Console.WriteLine("Person 2: How much do you make an hour? ");
            string p2_hourlyRate = Console.ReadLine();
            double p2HourlyRate = Convert.ToDouble(p2_hourlyRate);

            Console.WriteLine("Person 2: How many hours do you work in a week? ");
            string p2_hoursWorked = Console.ReadLine();
            int p2hoursWorked = Convert.ToInt32(p2_hoursWorked);

            // Getting the annual salary of each person
            double total1 = (((p1HourlyRate * p1hoursWorked) * 4) * 12);
            double total2 = (((p2HourlyRate * p2hoursWorked) * 4) * 12);

            // Displaying the salaries of each person
            Console.WriteLine("Annual Salary of Person 1: " + total1);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 2: " + total2);
            Console.ReadLine();

            bool comparison = total1 > total2;
            //Displaying whether or not person 1 makes more than person 2
            Console.WriteLine("Does person one make more than person two? " + comparison);
            Console.ReadLine();

        }
    }
}

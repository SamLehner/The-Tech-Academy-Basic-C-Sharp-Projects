using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Project
{
    class Program
    {
        static void Main()
        {
            // Making a string array 
            string[] strArray = { "Adam", "Betty", "Susie", "Bella", "Ben" };
            Console.WriteLine("Please enter \"happy\" or \"not happy\" for each person");
            string answer = Console.ReadLine();
            string[] answerArray = new string[5];

            // Taking user input to update the string values of the array
            for (int i = 0; i < strArray.Length; i++)
            {
                string input = strArray[i] + " is " + answer;
                answerArray[i] = input;
                
            }

            // Using < as an operator for a for loop
            for (int i = 0; i < answerArray.Length; i++)
            {
                Console.WriteLine(answerArray[i]);
            }
            
            // A for loop using <= as the operator
            for (int i = 3; i <= 7; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();

            // Creating a list of strings
            List<string> strList = new List<string>();
            strList.Add("APPLES");
            strList.Add("BANANAS");
            strList.Add("CHERRIES");
            strList.Add("APRICOTS");
            strList.Add("FIGS");
            strList.Add("OATS");

            // Asking for user input and checking to see if the value is on the list
            Console.WriteLine("Please enter your favorite food! ");
            string pick = Console.ReadLine();
            pick = pick.ToUpper();
            bool var1 = false;

            // Finding the index value of the input
            for (int i = 0; i < strList.Count; i++)
            {
                if (pick == strList[i])
                {
                    Console.WriteLine(i);
                    break;
                }
                if (!strList.Contains(pick))
                {
                    var1 = true;
                }
            }
            // If the input doesnt match any values on the list they will get this message
            if (var1)
            Console.WriteLine("Your selection isnt on the list. ");
            

            Console.ReadLine();

            // Creating another list of strings to check index value
            List<string> strList1 = new List<string>();
            strList1.Add("JEN");
            strList1.Add("BETH");
            strList1.Add("BETH");
            strList1.Add("SUSAN");
            strList1.Add("MARTHA");
            strList1.Add("RUBY");

            // Taking user input to find the index value on the list
            Console.WriteLine("Please enter your mothers name! ");
            string pick1 = Console.ReadLine();
            pick1 = pick1.ToUpper();
            bool var2 = false;

            // For loop to iterate through the list and find any index values mathing the input
            for (int i = 0; i < strList1.Count; i++)
            {
                if (pick1 == strList1[i])
                {
                    Console.WriteLine(i);
                }
                if (!strList1.Contains(pick1))
                {
                    var2 = true;
                }
            }
            if (var2)
                Console.WriteLine("Your selection isnt on the list. ");


            Console.ReadLine();


            // A new list of strings to check if the value has already showed up before
            List<string> listString = new List<string>();
            listString.Add("JEN");
            listString.Add("BETH");
            listString.Add("BETH");
            listString.Add("SUSAN");
            listString.Add("MARTHA");
            listString.Add("RUBY");
            listString.Add("BETH");

            // For each loop to check the index value to the count of the list to see if the value has shown up before
            int count = 0;
            foreach (string str in listString)
            {
                var index = listString.IndexOf(str);
                Console.WriteLine(str);
                if (index != count)
                {
                    Console.WriteLine("Already present");
                }
                count++;
            }

            Console.ReadLine();



        }
    }
}

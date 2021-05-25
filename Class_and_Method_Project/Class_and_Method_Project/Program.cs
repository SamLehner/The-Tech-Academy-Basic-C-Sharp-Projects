using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Method_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Math math = new Math();
            int answer4 = 0;
            
            Console.WriteLine("Please enter a number");
            int answer = Convert.ToInt32(Console.ReadLine());

            Math.Division(a: answer);
            Console.ReadLine();

            Console.WriteLine("Please enter one number");
            int answer2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter another number");
            int answer3 = Convert.ToInt32(Console.ReadLine());

            Math.Division(a: answer2, b: answer3, c: out answer4);
            Console.WriteLine(answer4);
            Console.ReadLine();

        }
    }
}

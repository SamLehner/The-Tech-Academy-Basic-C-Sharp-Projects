using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the employee class and giving it values
            Employee employee = new Employee("Sample", "Student");

            // Calling the SayName method thru the employee object we just created
            employee.SayName();
            Console.ReadLine();
        }
    }
}

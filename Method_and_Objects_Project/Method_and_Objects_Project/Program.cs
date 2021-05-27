using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_and_Objects_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the employee class and giving it values
            Employee employee = new Employee("Sample", "Student", 1);

            Employee employee1 = new Employee("Bungi", "Boyo", 2);

            bool eval = employee == employee1;



         
            Console.WriteLine(eval);
            // Calling the sayName method from person class since empolyee inherited it
            employee.SayName();
            Console.ReadLine();
        }
    }
}

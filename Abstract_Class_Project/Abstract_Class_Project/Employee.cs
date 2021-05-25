using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Project
{
    // Creating a CLass employee inheriting from our abstract class Person
    public class Employee : Person
    {
        // Creating a constructor for employee
        public Employee(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
        // Creating the method SayName from the inherited class Person
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}

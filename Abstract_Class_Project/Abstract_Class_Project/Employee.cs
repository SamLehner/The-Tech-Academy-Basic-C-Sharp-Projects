using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Project
{
    // Creating a CLass employee inheriting from our abstract class Person
    public class Employee : Person, IQuittable
    {
        // Creating a constructor for employee
        public Employee(string firstname, string lastname, int id)
        {
            FirstName = firstname;
            LastName = lastname;
            Id = id;
        }

        // Creating an int for the ID
        public int Id { get; set; }
        // Creating the method SayName from the inherited class Person
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

        public void Quit()
        {
            Console.WriteLine("You have quit the game");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_and_Objects_Project
{
    // Class inheritance from person
    public class Employee : Person
    {
        // Adding a constructor for first anf last name
        public Employee(string firstname, string lastname, int id)
        {
            FirstName = firstname;
            LastName = lastname;
            Id = id;
        }
        public int Id { get; set; }



        public static bool operator== (Employee employee, Employee employee1 )
        {
            return employee.Id.Equals(employee1.Id);
        }

        public static bool operator!= (Employee employee, Employee employee1)
        {
            return !employee.Id.Equals(employee1.Id);
        }

    }
}

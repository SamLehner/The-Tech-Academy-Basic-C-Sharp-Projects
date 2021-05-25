using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Project
{
    // Creating an abstract Class of person 
    public abstract class Person
    {
        // Creating properties of FirstName and LastName
        public string FirstName { get; set; }

        public string LastName { get; set; }

        // Creating an abstract method of sayName
        public abstract void SayName();

    }
}

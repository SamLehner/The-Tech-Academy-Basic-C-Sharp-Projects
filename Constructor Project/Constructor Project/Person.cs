using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Project
{
    public class Person
    {
        // Overriding our constructor so wellness will have a value of OKay if left blank
        public Person(string name) : this (name, " Okay" )
        {

        }

        // Our person constructor
        public Person(string name, string wellness)
        {
            Name = name;
            Wellness = wellness;

        }
        // Our person properties
        public string Name { get; set; }
        public string Wellness { get; set; }
    }
}

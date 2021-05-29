using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Project
{
    public class Person
    {
        public Person(string name) : this (name, " Okay" )
        {

        }
        public Person(string name, string wellness)
        {
            Name = name;
            Wellness = wellness;

        }

        public string Name { get; set; }
        public string Wellness { get; set; }
    }
}

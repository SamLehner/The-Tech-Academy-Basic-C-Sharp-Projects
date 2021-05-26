using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Project
{
    public class Weekdays
    {
        // Out property of Weekdays
        public Weekday Weekday { get; set; }
    }

    // Our enum for weekdays
    public enum Weekday
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}

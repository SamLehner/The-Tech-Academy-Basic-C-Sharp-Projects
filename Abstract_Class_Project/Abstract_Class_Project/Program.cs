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
            List<Employee> employeeList = new List<Employee>();

            employeeList.Add(new Employee(firstname: "Jesse", lastname: " Smith", id: 0 ));
            employeeList.Add(new Employee(firstname: "Elaine", lastname: " Worses", id: 1));
            employeeList.Add(new Employee(firstname: "Joe", lastname: " Wales", id: 2));
            employeeList.Add(new Employee(firstname: "Bobby", lastname: " Junior", id: 3));
            employeeList.Add(new Employee(firstname: "Ricky", lastname: " Germaine", id: 4));
            employeeList.Add(new Employee(firstname: "Joe", lastname: " Sagat", id: 5));
            employeeList.Add(new Employee(firstname: "Sam", lastname: " Lehner", id: 6));
            employeeList.Add(new Employee(firstname: "Jimmy", lastname: " Leonard", id: 7));
            employeeList.Add(new Employee(firstname: "Romone", lastname: " Iglesias", id: 8));
            employeeList.Add(new Employee(firstname: "Susie", lastname: " Quentin", id: 9));

            List<Employee> joe_employeeList = new List<Employee>();

            List<Employee> iD_employeeList = new List<Employee>();

            foreach (Employee employee in employeeList.Where(f => f.FirstName == "Joe"))
            {
                    joe_employeeList.Add(employee);
            }
            foreach (Employee employee in joe_employeeList)
            {
                Console.WriteLine(employee.FirstName + employee.LastName);
            }

            foreach (Employee employee in employeeList.Where(i => i.Id > 5))
            {
                iD_employeeList.Add(employee);
            }
            foreach (Employee employee in iD_employeeList)
            {
                Console.WriteLine(employee.FirstName + employee.Id);
            }


            Console.WriteLine(employeeList.Count);
            Console.ReadLine();

            //// Instantiating the employee class and giving it values
            //Employee employee = new Employee("Sample", "Student", 3);

            //// Calling the SayName method thru the employee object we just created
            //employee.SayName();

            //employee.Quit();
            //Console.ReadLine();
        }
    }
}

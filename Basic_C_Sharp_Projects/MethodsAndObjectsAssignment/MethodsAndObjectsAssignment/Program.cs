using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" }; // instantiates an employee with a first and last name
            employee.SayName(); // calls SayName() method
            Console.ReadLine(); // so we have time to see the results on the screen
        }
    }
}

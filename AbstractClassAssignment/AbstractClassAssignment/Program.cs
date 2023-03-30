using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" }; // instantiates an employee with a first and last name
            employee.SayName(); // calls SayName() method
            Console.ReadLine(); // so we have time to see the results on the screen
        }
    }
}

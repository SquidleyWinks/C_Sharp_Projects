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
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student", Id = 100 }; // instantiates an employee with a first and last name
            employee.SayName(); // calls SayName() method
            IQuittable quitter = new Employee() { firstName = "I", lastName = "Quit", Id = 200 }; // polymorphs an employee into an IQuittable
            quitter.Quit(); // calls Quit method
            Employee sample = new Employee() { firstName = "Student", lastName = "Sample", Id = 100 }; // creating another sample student with a different name
            Employee test = employee == sample; // utilizes our overloaded operator
            Console.ReadLine(); // so we have time to see the results on the screen
        }
    }
}

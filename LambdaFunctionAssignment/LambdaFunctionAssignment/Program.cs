using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunctionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> staff = new List<Employee>() 
            { 
                new Employee() { Id = 1, firstName = "Joe", lastName = "Bob"},
                new Employee() { Id = 2, firstName = "Bob", lastName = "Joeson"},
                new Employee() { Id = 3, firstName = "Billy", lastName = "JoeBob"},
                new Employee() { Id = 4, firstName = "Joe", lastName = "Bobert"},
                new Employee() { Id = 5, firstName = "Joe", lastName = "Bobson"},
                new Employee() { Id = 6, firstName = "Joe", lastName = "Bobbino"},
                new Employee() { Id = 7, firstName = "Bob", lastName = "Joebert"},
                new Employee() { Id = 8, firstName = "Steve", lastName = "Willson"},
                new Employee() { Id = 9, firstName = "Pete", lastName = "Parker"},
                new Employee() { Id = 10, firstName = "Joe", lastName = "Schmo"}

            };
            List<Employee> joeStaff1 = new List<Employee>(); // create a new list for just the Joes
            foreach (Employee joe in staff) // foreach loop
            {
                if (joe.firstName == "Joe") // checks for the first name to be equal to the firstName string
                {
                    joeStaff1.Add(joe); // adds to new list
                }
            }
            List<Employee> joeStaff2 = staff.Where(x => x.firstName == "Joe").ToList(); // the lambda function version is much more compact -- had to add in an extra cast at the start to set the staff object to a list of employees (which it is already, functionally speaking)
            List<Employee> over5Staff1 = new List<Employee>();
            foreach(Employee over5 in staff) // foreach loop
            {
                if (over5.Id > 5) // checks if id is over 5
                {
                    over5Staff1.Add(over5); // adds to the new list
                } 
            }
            List<Employee> over5Staff2 = staff.Where(x => x.Id > 5).ToList(); // again, much more compact 
        }
    }
}

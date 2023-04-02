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
            Staff staff = new Staff(); // create our staff
            List<Employee> joeStaff1 = new List<Employee>(); // create a new list for just the Joes
            foreach (Employee joe in staff.Employees) // foreach loop
            {
                if (joe.firstName == FirstNames.Joe) // checks for the first name to be equal to the enum
                {
                    joeStaff1.Add(joe); // adds to new list
                }
            }
            List<Employee> joeStaff2 = (List<Employee>)staff.Employees.Where(x => x.firstName == FirstNames.Joe); // the lambda function version is much more compact -- had to add in an extra cast at the start to set the staff object to a list of employees (which it is already, functionally speaking)
            List<Employee> over5Staff1 = new List<Employee>();
            foreach(Employee over5 in staff.Employees) // foreach loop
            {
                if (over5.Id > 5) // checks if id is over 5
                {
                    over5Staff1.Add(over5); // adds to the new list
                } 
            }
            List<Employee> over5Staff2 = (List<Employee>)staff.Employees.Where(x => x.Id > 5); // again, much more compact 
        }
    }
}

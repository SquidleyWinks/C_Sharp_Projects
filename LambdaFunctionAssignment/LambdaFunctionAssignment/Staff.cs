using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunctionAssignment
{
    public class Staff // created this class simply as a way to generate employees.
    {
        public Staff() // here's our staff constructor
        {
            List<string> firstNames = new List<string>() { "Joe", "Bob", "Ned", "Ted" }; // tried to use enums, but something broke, so I'm going with a list of names within the constructor instead
            List<string> lastNames = new List<string>() { "Bob", "Steve", "Willy", "Billy" };
            Employees = new List<Employee>(); // creates the list, our one property
            for (int i = 0; i < 4;  i++) // nested for loops set to 4, the number of first and last names we have
            {
                for (int j = 0; j < 4; j++)
                {
                    Employee joe = new Employee(); // creates a new employee
                    joe.firstName = firstNames[i]; // sets firstname from firstNames list at index of i
                    joe.lastName = lastNames[j]; // sets lastname from lastNames list at index of j
                    joe.Id = i + j; // almost had this as just i, but then I realized it would never get above 4, so I figured adding i and j togetehr would get us some variety, but also repetition
                    Employees.Add(joe); // adds employee to the list
                }
            }
        }
        public List<Employee> Employees { get; set; } // our one property, the Staff is a list of employees

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person, IQuittable // inherits from Person class and IQuittable interface
    {
        public int Id { get; set; }
        
        public override void SayName() // included override keyword to implement the abstract method SayName()
        {
            string fullName = firstName + " " + lastName; // created new variable to combine first and last names
            Console.WriteLine("Name: " + fullName); // displays to screen
        }

        public void Quit() // implements the Quit() method
        {
            Console.WriteLine("I Quit!!!"); // gets the point across
        }

        public static Employee operator== (Employee a, Employee b) // overloading the == operator so that it compares employees by Id
        {
            if (a.Id == b.Id) // if the employees have the same Id, then the first employee is returned
            {
                Console.WriteLine("This is the same employee."); // informs user via console
                return a; 
            }
            else // if the employees do not have the same Id, then the second employee is returned
            {
                Console.WriteLine("These are two different employees.");
                return b;
            }
        }
        public static Employee operator!= (Employee a, Employee b) // since operators need to be overloaded in pairs, I decided to make them function in effectively the same way (or, at least as close as I could get in a way that made sense)
        {
            if (a.Id != b.Id) // if the employees do not have the same Id, then the second employee is returned
            {
                Console.WriteLine("These are two different employees.");
                return b;
            }
            else // if the employees have the same Id, then the first employee is returned
            {
                Console.WriteLine("This is the same employee.");
                return a;
            }
        }
    }
}

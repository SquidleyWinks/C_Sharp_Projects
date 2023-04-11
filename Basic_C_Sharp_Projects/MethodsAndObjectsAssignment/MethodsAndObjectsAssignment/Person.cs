using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    public class Person
    {
        public string FirstName { get; set; } // make sure these are public so that their values can be set upon instantiation (learned that the hard way)
        public string LastName { get; set; }

        public void SayName() // method used to display a Person Object's full name
        {
            string FullName = FirstName + " " + LastName; // created new variable to combine first and last names
            Console.WriteLine("Name: " + FullName); // displays to screen
        }
    }
}

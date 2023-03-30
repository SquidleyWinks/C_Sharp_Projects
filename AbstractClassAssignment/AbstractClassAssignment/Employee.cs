using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person
    {
        public override void SayName() // included override keyword to implement the abstract method SayName()
        {
            string fullName = firstName + " " + lastName; // created new variable to combine first and last names
            Console.WriteLine("Name: " + fullName); // displays to screen
        }
    }
}

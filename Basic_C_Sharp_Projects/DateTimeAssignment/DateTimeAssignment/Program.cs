using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); // prints DateTime of Now to the console
            Console.WriteLine("Please provide a number:"); // prompts user for a number
            int x = Convert.ToInt32(Console.ReadLine()); // sets variable for user number
            Console.WriteLine(DateTime.Now.AddHours(x)); // uses AddHours() method on DateTime.Now to add the user's input (in hours) to the current time
            Console.ReadLine();
        }
    }
}

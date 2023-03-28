using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:"); // prompts for a number
            int userNum1 = Convert.ToInt32(Console.ReadLine()); // sets variable converting user input to int
            Console.WriteLine("The result is " + Maths.AddInt(userNum1)); // calls overloaded method that takes in an int, and displays result

            Console.WriteLine("Please enter a decimal number:"); // prompts for a decimal number
            double userNum2 = Convert.ToDouble(Console.ReadLine()); // sets variable converting user input to double
            Console.WriteLine("The result is " + Maths.AddInt(userNum2)); // calls overloaded method that takes in a double and displays result

            Console.WriteLine("Please enter a number:"); // prompts for another number
            string userNum3 = Console.ReadLine(); // stores value as a string
            Console.WriteLine("The result is " + Maths.AddInt(userNum3)); // calls overloaded method that takes in a string and displays result
            Console.ReadLine(); // one last readline so we can see everything on the console
        }
    }
}

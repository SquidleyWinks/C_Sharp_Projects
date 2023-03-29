using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StaticClass.HelloWorld(); // utilizes the static class StaticClass
            Maths maths = new Maths(); // instantiating Maths class
            int numHalved = 0; // declaring output parameter variable
            Console.WriteLine("Please select a number to cut in half"); // prompts user for a number
            int userNum = Convert.ToInt32(Console.ReadLine()); // sets the number to a variable
            Maths.CutInHalf(userNum, out numHalved); // performs method using the output parameter
            Console.WriteLine("The result is: " + numHalved); // displays result to screen
            Console.ReadLine(); // in place so we have time to see the results
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Package weight?");
            int packageWeight = Convert.ToInt32(Console.ReadLine()); // converts input to int
            if (packageWeight > 50) // checks the weight
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Good day.");
                Console.ReadLine();
                Environment.Exit(0); // exits the application if limit is exceeded
            }
            Console.WriteLine("Package width?");
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Package height?");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Package length?");
            int packageLength = Convert.ToInt32(Console.ReadLine());
            int packageSize = packageWidth + packageHeight + packageLength; // combines dimensions
            if (packageSize > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Good day.");
                Console.ReadLine();
                Environment.Exit(0); // exits the application, but only if the limit is exceeded
            }
            int result = (packageHeight * packageLength * packageWidth * packageWeight) / 100; // calculates exorbitant pricing
            Console.WriteLine("Your estimated total for shipping this package is: $" + result + ".00"); // probably not the smoothest display of result as money, but it gets the job done
            Console.ReadLine();
        }
    }
}

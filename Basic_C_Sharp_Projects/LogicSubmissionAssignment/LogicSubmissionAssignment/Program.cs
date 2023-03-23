using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine()); // converts age answer to int
            Console.WriteLine("Have you ever had a DUI? (please answer \"true\" or \"false\")"); // specifies "true" or "false" in answer
            bool DUI = Convert.ToBoolean(Console.ReadLine()); // converts answer to bool
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine()); // converts answer to int
            Console.WriteLine("Qualified?");
            bool Qualified = age > 15 && !DUI && tickets < 4; // checks that age is over 15, DUI = false, and no more than 3 tickets
            Console.WriteLine(Qualified.ToString()); // don't forget to convert answer to string!
            Console.ReadLine();
        }
    }
}

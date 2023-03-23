using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathComparisonAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate:");
            double hourlyRate1 = Convert.ToDouble(Console.ReadLine()); // picks up input from user and converts to double
            Console.WriteLine("Hours worked per week:");
            double hoursWorked1 = Convert.ToDouble(Console.ReadLine()); // picks up input from user and converts to double == stores answer in a variable
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate:");
            double hourlyRate2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week:");
            double hoursWorked2 = Convert.ToDouble(Console.ReadLine());
            double annualSalary1 = hourlyRate1 * hoursWorked1 * 52; // calculates annual salary by multiplying rate by hours worked by 52 (weeks per year)
            Console.WriteLine("Annual salary of Person 1: " + annualSalary1); // caconicates string w/ integer
            double annualSalary2 = hourlyRate2 * hoursWorked2 * 52;
            Console.WriteLine("Annual salary of Person 2: " + annualSalary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool makesMore = annualSalary1 > annualSalary2; // compares salaries to see if Person 1 makes more than Person 2
            Console.WriteLine(makesMore.ToString()); // make sure to convert that bool result to a string for print!
            Console.ReadLine(); // one last readline so we can see the results
        }
    }
}

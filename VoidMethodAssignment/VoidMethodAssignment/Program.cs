using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hopefully this fulfills the requirements, because it is quite the underwhelming app experience
            
            Console.WriteLine("Please select a number:"); // prompts user for the first number
            int num1 = Convert.ToInt32(Console.ReadLine()); // stores to variable
            Console.WriteLine("Please select a second number:"); // prompts user for the second number
            int num2 = Convert.ToInt32(Console.ReadLine()); // stores to another variable
            VoidClass.ShowOff(firstNum: num1, secondNum: num2); // passes the user's input into the method, naming the parameters
            Console.ReadLine(); // final ReadLine() so that we can see what was displayed to the console
        }
    }
}

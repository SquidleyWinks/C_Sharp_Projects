using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignmentOptionalParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a number:"); // prompt for first number
            int userNum1 = Convert.ToInt32(Console.ReadLine()); // converts user input to int and stores value in a variable
            Console.WriteLine("You may now select another number, or just press \'Enter\' to select the default."); // prompts user for second, optional number
            string optionalNum = Console.ReadLine(); // stores the reply as a string, in case they choose the default
            if(optionalNum != "") // checks the optional number response variable, and executes following code if the user entered their own number
            {
                int userNum2 = Convert.ToInt32(optionalNum); // converts the optional variable from string to int
                Console.WriteLine("The result is: " + Maths.AddTwo(userNum1, userNum2)); // calls our AddTwo method and displays the result to the screen
            }
            else // executes if the user opted for the default number value
            {
                Console.WriteLine("The result is: " + Maths.AddTwo(userNum1)); // calls AddTwo method with a single input, utilizing the default
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try // start try block
            {
                List<int> ints = new List<int>() { 22, 24, 30, 32, 36, 40 }; // sets up initial list of numbers
                Console.WriteLine("Select a number for division"); // prompt for user input
                int denum = Convert.ToInt32(Console.ReadLine()); // sets variable for user input
                for (int i = 0; i < ints.Count; i++) // establishes for loop
                {
                    int quotient = ints[i] / denum; // divides list index by user input and stores that value in a variable
                    Console.WriteLine(quotient.ToString()); // displays result to screen
                }
            }
            catch(DivideByZeroException ex) // looks for divide by zero exception
            {
                Console.WriteLine(ex.Message); // displays error message
            }
            catch(FormatException ex) // looks for wrong format exception
            {
                Console.WriteLine(ex.Message); // displays error message
            }
            catch(Exception ex) // looks for any other exception
            {
                Console.WriteLine(ex.Message); // error message
            }
            Console.WriteLine("Emerged from Try/Catch block."); // marks the end of the try/catch block
            Console.ReadLine();
            {

            }
        }
    }
}

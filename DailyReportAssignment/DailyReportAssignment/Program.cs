using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Starts with intro lines printed
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine(); 
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            int currentPage = Convert.ToInt32(Console.ReadLine()); // converts answer from string to int
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\""); // escape characters used
            bool needHelp = Convert.ToBoolean(Console.ReadLine()); // converts answer from string to bool
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string specificHelp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int studyHours = Convert.ToInt32(Console.ReadLine()); // another string to int
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine(); // added so that you can see the final message
        }
    }
}

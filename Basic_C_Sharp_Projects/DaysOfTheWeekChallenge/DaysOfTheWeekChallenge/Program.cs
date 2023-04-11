using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfTheWeekChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("What day of the week is it?"); // asks user for the current day of the week
                weekDays userDay = (weekDays)Enum.Parse(typeof(weekDays), Console.ReadLine()); // parses enum to see if the string entered by the user is within the acceptable ansers fo the enum type
                Console.WriteLine("The day of the week is: " + userDay.ToString()); // prints user's answer to the screen
                Console.ReadLine();
            }
            catch  // if the user doesn't enter a day of the week, this will alert them
            {
                Console.WriteLine("Please enter an actual day of the week. (or, check your spelling and capitalization.)");
                Console.ReadLine();
            }
            
        }

        public enum weekDays // creates an enum for the days of the week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}

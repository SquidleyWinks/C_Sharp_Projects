using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is a simple program
            //    Console.WriteLine("What is your name?");
            //    string yourName = Console.ReadLine();
            //    Console.WriteLine("Your name is: " + yourName);
            //    Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemp = -23;
            char qMark = '\u2103';

            decimal money = 100.5m;

            double height = 211.3020290;

            float seconds = 2.62f;

            short temp = -341;

            string myName = "Phil";

            int currentAge = 32;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainstat = Convert.ToString(isRaining);


            Console.WriteLine(qMark);
            Console.ReadLine();

        }
    }
}

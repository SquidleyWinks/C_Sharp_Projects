using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment
{
    internal class VoidClass
    {
        public static void ShowOff(int firstNum, int secondNum) // not the flashiest method, which is ironic given the name
        {
            firstNum++; // takes in first parameter and increments it
            Console.WriteLine(secondNum.ToString()); // displays second parameter to the console
        }
    }
}

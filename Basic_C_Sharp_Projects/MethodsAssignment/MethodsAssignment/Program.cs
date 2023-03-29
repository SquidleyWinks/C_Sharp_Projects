using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number for some Maths:");
            int userNum = Convert.ToInt32(Console.ReadLine());

            userNum = Maths.AddFive(userNum);
            Console.WriteLine("Result of first method is " + userNum);
            userNum = Maths.MultFive(userNum);
            Console.WriteLine("Result of second method is " + userNum);
            userNum = Maths.MinusFive(userNum);
            Console.WriteLine("Result of third method is " + userNum);
            Console.ReadLine();


        }
    }
}

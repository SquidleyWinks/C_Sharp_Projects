using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0; // sets counter variable
            while (i < 10) // condition to perform loop while i less than 10
            {
                Console.WriteLine(i); // produce i
                i++; // increment
            }
            Console.ReadLine(); // lets us look at the results
            int j = 0; // another counter variable
            do // do/while loop this time
            {
                Console.WriteLine(j); // produce j
                j++; // increment
            }
            while (j < 10); // condition down here
            Console.ReadLine(); // lets us take in the work
        }
    }
}

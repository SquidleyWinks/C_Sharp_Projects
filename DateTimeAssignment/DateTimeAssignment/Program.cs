using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please provide a number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DateTime.Now.AddHours(x));
            Console.ReadLine();
        }
    }
}

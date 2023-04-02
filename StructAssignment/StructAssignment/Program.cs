using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number(); // created new instance of struct type Number
            num.Amount = 5.5m; // had to use m to indicate decimal data type
            Console.WriteLine(num.Amount.ToString()); // displayed Amount to console by converting to string
            Console.ReadLine();
        }
    }
}

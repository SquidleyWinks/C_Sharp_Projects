using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment_.NetFramework_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Hello = "Hello, ";
            var World = "World!";
            var chian = new Chain();
            Console.WriteLine(Hello + World);
            Console.ReadLine();
        }
    }
}

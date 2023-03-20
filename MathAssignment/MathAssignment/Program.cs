using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number pwease");
            long myNum = Convert.ToInt64(Console.ReadLine());
            long mathNum = myNum * 50;
            Console.WriteLine(mathNum.ToString());
            Console.WriteLine("NUMBER PWEASE");
            int addNum = Convert.ToInt32(Console.ReadLine());
            int plus25 = addNum + 25;
            Console.WriteLine(plus25.ToString());
            Console.WriteLine("NUUUUUUUMBER PWEEEEEEEASE");
            double divideNum = Convert.ToDouble(Console.ReadLine());
            double divideBy = divideNum / 12.5;
            Console.WriteLine(divideBy.ToString());
            Console.WriteLine("This has been a reference to Mona Lisa Saperstine from Parks and Rec. (number please)");
            int over50 = Convert.ToInt32(Console.ReadLine());
            bool check = over50 > 50;
            Console.WriteLine(check.ToString());
            Console.WriteLine("Last One, promise");
            int lastOne = Convert.ToInt32(Console.ReadLine());
            int remainder = lastOne % 7;
            Console.WriteLine(remainder.ToString());
            Console.ReadLine();


        }
    }
}

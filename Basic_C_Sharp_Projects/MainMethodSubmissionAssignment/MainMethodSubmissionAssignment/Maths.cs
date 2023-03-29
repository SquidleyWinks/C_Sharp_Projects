using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmissionAssignment
{
    internal class Maths
    {
        public static int AddInt(int i) // first simple method, takes in an int, adds 5, then returns an int
        {
            i += 5;
            return i;
        }

        public static int AddInt(double d) // first overload of the simple method. Takes in a double, adds 10, then returns as an int
        {
            d += 10;
            return Convert.ToInt32(d);
        }

        public static int AddInt(string s) // second overload of the simple method. Takes in a string, adds 20, then returns as an int
        {
            int num = Convert.ToInt32(s); // make sure to convert before attempting math operations
            num += 20;
            return num; // returns new variable as int
            
        }
    }
}

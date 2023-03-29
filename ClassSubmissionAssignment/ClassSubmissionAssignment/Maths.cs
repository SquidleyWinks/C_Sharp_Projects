using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    internal static class Maths // class declared static
    {
        public static void CutInHalf(int num, out int numHalved) // void method with output parameter gets past the "return" keyword
        {
            numHalved = num / 2; // sets output parameter to input parameter divided by 2
        }

        public static int CutInHalf(int num) // overloaded the method without the void modefier
        {
            num /= 2; // divides input number by 2
            return num; // returns result
        }
    }
}

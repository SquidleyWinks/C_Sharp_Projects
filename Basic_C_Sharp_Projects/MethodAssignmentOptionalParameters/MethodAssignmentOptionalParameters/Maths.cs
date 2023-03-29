using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignmentOptionalParameters
{
    internal class Maths
    {
        public static int AddTwo(int a, int b = 5) // adds two integers together, with the second number being option, with a default of 5
        {
            int result = a + b;
            return result;
        }
    }
}

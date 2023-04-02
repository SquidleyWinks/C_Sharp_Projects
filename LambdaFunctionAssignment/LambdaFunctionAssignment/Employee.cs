using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunctionAssignment
{
    public class Employee
    {
        public int Id { get; set; }
        public FirstNames firstName { get; set; }
        public LastNames lastName { get; set; }

    }
    public enum FirstNames // some odd first names for our staff
    {
        Joe,
        Bob,
        Ned,
        Ted
    }

    public enum LastNames // made the properties enums for the sake of easily maintaining the possible names
    {
        Bob,
        Steve,
        Willy,
        Billy
    }
}

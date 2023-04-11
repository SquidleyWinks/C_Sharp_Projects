using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public interface IQuittable
    {
        int Id { get; }
        void Quit(); // sets up the method for inheritors to implement
    }
}

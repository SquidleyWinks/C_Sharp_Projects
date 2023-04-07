using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment_.NetFramework_
{
    internal class Chain
    {
        public Chain() : this(6)
        { 

        }
        public Chain(int Links) : this(Links, "Padlock") 
        {
        }
        public Chain(int Links, string Locks)
        {
            this.Links = Links;
            this.Locks = Locks;
        }
        public int Links { get; set; }
        public string Locks { get; set; }
    }
}

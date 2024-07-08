using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inheritance
{
    internal class Child : Parent
    {
        public int Z { get; set; }
        public Child(int x , int y , int z) : base(x,y)
        {
            Z = z;
        }
        public override string ToString()
        {
            return $"{X} , {Y} , {Z}";
        }
    }
}

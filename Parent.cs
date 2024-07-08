using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inheritance
{
    internal class Parent
    {
        #region Prperties
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region Constructor
        public Parent(int x , int y) {
            X = x;
            Y = y;
        } 
        public Parent() { }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{X} , {Y}";
        }
        
        public int Product()
        {
            return X*Y;
        }
        #endregion
    }
}

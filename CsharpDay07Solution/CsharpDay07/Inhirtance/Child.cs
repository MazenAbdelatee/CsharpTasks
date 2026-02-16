using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay07.Inhirtance
{
    internal class Child : Parent
    {
        #region Attributes
        private int z; 
        #endregion

        #region Properties
        public int Z { get; set; } 
        #endregion
        
        #region Constructor
        public Child(int _X, int _Y, int _Z) : base(_X, _Y)
        {
            z = _Z;
        } 
        #endregion
        
        #region Methods
        // usign override 
        public override int Product()
        {
            return base.Product() * z;
        }

        // using new keyword
        //public new int Product() {
        //    return X * Y * z;
        //} 

        public override string ToString()
        {
            return $"({X},{Y}, {z})";
        }
        #endregion
    }
}

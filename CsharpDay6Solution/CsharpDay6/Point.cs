using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay6
{
    internal struct Point
    {
        #region Attributes 
        private int x;
        private int y;
        #endregion

        #region Constructor 
        public Point(int _X, int _Y)
        {
            x = _X;
            y = _Y;
        }

        public Point(int _X) : this(_X, 0) { }
        #endregion



        public override string ToString()
        {
            return $"Point ( {x} , {y} )";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay07.Inhirtance
{
    internal class Parent
    {
        #region Attributes
        private int x, y; 
        #endregion

        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region Constructor
        public Parent(int _X, int _Y)
        {
            x = _X;
            y = _Y;
        }
        #endregion

        #region Methods
        public virtual int Product()
        {
            return x * y;
        }

        public override string ToString()
        {
            return $"({x},{y})";
        }
        #endregion
    }
}

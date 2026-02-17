using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay8.InterfacePartTwo
{
    internal class SquareSeries : IShapeSeries
    {
        private int side = 1 ;
        public double CurrentShapeArea { get ; set ; }
        #region Methods
        public void CalcArea()
        {

            CurrentShapeArea = side * side;
        }
        public void GetNextArea()
        {
            side++;
            CalcArea();
        }

        public void ResetArea()
        {
            CurrentShapeArea = 1;
        } 
        #endregion
    }
}

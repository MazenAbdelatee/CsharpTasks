using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay8.InterfacePartTwo
{
    internal class CircleSeries : IShapeSeries
    {
        private double radius = 1;
        public double CurrentShapeArea { get; set; }

        #region Methods
        public void CalcArea()
        {
            CurrentShapeArea = radius * radius * Math.PI;
        }

        public void GetNextArea()
        {
            radius++;
            CalcArea();
        }

        public void ResetArea()
        {
            radius = 1;
            CalcArea();
        } 
        #endregion
    }
}

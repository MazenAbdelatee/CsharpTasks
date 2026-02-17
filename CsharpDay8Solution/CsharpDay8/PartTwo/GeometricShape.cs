using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay8.PartTwo
{
    internal abstract  class GeometricShape
    {
        #region Properties
        public double DimensionOne { get; set; }
        public double DimensionTwo { get; set; }
        public abstract double Permiter { get;  }
        #endregion

        public abstract double CalcluateArea();

    }
}

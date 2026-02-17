using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay8.PartTwo
{
    internal class Triangle : GeometricShape
    {
        public double DimThree { get; set;  }
        public override double Permiter => DimensionTwo+ DimensionOne +DimThree;

        public override double CalcluateArea()
        {
            return 0.5 * DimensionOne * DimensionTwo;
        }
    }
}

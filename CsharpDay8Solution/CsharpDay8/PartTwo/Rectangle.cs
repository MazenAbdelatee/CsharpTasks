using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay8.PartTwo
{
    internal class Rectangle : GeometricShape
    {
        public override double Permiter => 2*(DimensionOne + DimensionTwo);

        public override double CalcluateArea()
        {
            return DimensionOne * DimensionTwo;
        }
    }
}

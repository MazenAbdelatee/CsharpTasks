using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay07.Inhirtance
{
    internal class Rectangle : Shape
    {
        public override double CalculateArea()
        {
            return DiminsionOne * DiminsionTwo;
        }
        public override void Draw()
        {
            Console.WriteLine("this is rectangle drawing func");
        }
    }
}

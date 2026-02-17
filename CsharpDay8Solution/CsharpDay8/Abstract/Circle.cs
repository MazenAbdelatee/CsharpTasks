using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay8.Abstract
{
    internal class Circle : Shape
    {
        public double radius{ get; set; }
        public override double GetArea()
        {
            return Math.PI * radius * radius;

        }
    }
}

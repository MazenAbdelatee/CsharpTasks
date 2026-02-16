using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay07.Inhirtance
{
    internal abstract class Shape
    {
        public int DiminsionOne { get; set; }
        public int DiminsionTwo { get; set; }
        public virtual void Draw() {
            Console.WriteLine("Drawing shape");
        }
          public abstract double CalculateArea();
    }
}

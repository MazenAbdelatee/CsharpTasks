using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay8.Abstract
{
    internal abstract class Shape
    {
        public abstract double GetArea();
        public void Display() {
            Console.WriteLine("Displaying the shape");
        }
    }
}

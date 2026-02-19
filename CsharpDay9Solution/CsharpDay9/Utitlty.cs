using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay9
{
    internal class Utitlty
    {
        public static int CalcRectangleArea(int length, int width) {
            return length * width ; 
        }

        public static double CelsiusToFahrenheit(double temp) {
            return temp * (9/5) + 32 ;
        }
    }
}

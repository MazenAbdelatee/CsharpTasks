using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay07.MethodChainingWithOverloading
{
    internal class Calculator {
        private Calculator() { } // no need take instance from this class

        public static int Sum(int A, int B) {
            return A + B;
        }
        public static int Sum(int A, int B,int C)
        {
            return A + B + C;
        }
        public static double Sum(double A, double B)
        {
            return A + B ;
        }
    }
}

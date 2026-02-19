using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay9
{
    internal class ComplexNumber
    {
        public int Real { get; set; }
        public int Imag { get; set; }


        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        public static ComplexNumber operator +(ComplexNumber Left, ComplexNumber Right)
        {
            return new ComplexNumber()
            {
                Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) + (Right?.Imag ?? 0),
            };
        }



        public static ComplexNumber operator -(ComplexNumber Left, ComplexNumber Right)
        {
            return new ComplexNumber
            {
                Real = Left.Real - Right.Real,
                Imag = Left.Imag - Right.Imag,
            };
        }

        public static ComplexNumber operator *(ComplexNumber Left, ComplexNumber Right) {
            //num one 5+3i 
            //num two 3+4i
            //(5+3i)(3+4i) = 5*3 + 5*4i + 3*3i + 3i*3i;
            //int ProductReal = Left.Real * Right.Real - Left.Imag * Right.Imag;
            //int ProductImag = Right.Real * Left.Imag + Left.Real *Right.Imag ;


            return new ComplexNumber {
                Real = Left.Real * Right.Real - Left.Imag * Right.Imag,
                Imag = Right.Real * Left.Imag + Left.Real * Right.Imag
            }
           ;
        } 
    }
}

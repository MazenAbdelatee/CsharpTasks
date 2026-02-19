using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay9
{
    internal struct Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public void Swap() { 
            int temp = Length;
            Length = Width;
            Width = temp;

        }
    }
}

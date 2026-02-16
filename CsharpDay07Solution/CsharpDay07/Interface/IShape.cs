using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay07.Interface
{
    internal interface IShape
    {
        double Area { get; }
        void Draw();

        void PrintDetails() {
            Console.WriteLine($" The shape area is  { Area }");
        }
    }
}

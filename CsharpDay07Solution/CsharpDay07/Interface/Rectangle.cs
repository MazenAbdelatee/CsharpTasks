using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay07.Interface
{
    internal class Rectangle : IShape
    {
        #region Attributes
        private int length;
        private int width;
        #endregion

        #region Properties
        public int Length { get; set; }
        public int Width { get; set; }

        public double Area => length * width;
        #endregion

        #region Constructor
        public Rectangle(int L, int W)
        {
            length = L;
            width = W;
        }
        #endregion

        #region Methods
        public void Draw()
        {
            Console.WriteLine("This is Rectangle Draw function");
        } 
        #endregion
    }
}

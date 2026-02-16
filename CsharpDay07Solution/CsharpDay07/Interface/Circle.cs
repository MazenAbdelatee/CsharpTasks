using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay07.Interface
{
    internal class Circle : IShape
    {
        #region Attributes
        private double radius;
        #endregion
        #region Properties
        public double Radius { get; set; } 
        public double Area => 2*Math.PI * radius;
        #endregion
        #region Constructor
        public Circle(double r) { radius = r; }
        #endregion

        #region Methods
        public void Draw()
        {
            Console.WriteLine("This is circle draw function");
        } 
        #endregion
    }
}

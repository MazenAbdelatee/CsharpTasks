using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay8.InterfacePartTwo
{
    internal interface IShapeSeries
    {
        public double CurrentShapeArea { get; set; }

        #region Methods
        void GetNextArea();

        void ResetArea();

        void CalcArea();

        void PrintTenShapes(IShapeSeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.CurrentShapeArea);
                series.GetNextArea();
            }
            series.ResetArea();
        } 
        #endregion 

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay8.InterfacePartTwo
{
    internal class Shape : IComparable
    {
        #region Attributes
        public string Name { get; set; }
        public double Area { get; set; } 
        #endregion

        public Shape(string _Name , double _Area)
        {
            Name = _Name;
            Area = _Area;
        }
        public int CompareTo(object obj)
        {
            Shape temp = (Shape)obj;
            return Area.CompareTo(temp?.Area);
        }
        public override string ToString()
        {
            return $"Shape  : {Name}  & Area = {Area}  ";
        }
    }
}

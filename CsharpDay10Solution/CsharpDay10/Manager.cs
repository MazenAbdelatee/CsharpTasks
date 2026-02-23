using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay10
{
    internal class Manager : Employee, IComparable<Manager>
    {
        public int CompareTo(Manager other)
        {
            return this.Salary.CompareTo(other.Salary);
        }
    }
}

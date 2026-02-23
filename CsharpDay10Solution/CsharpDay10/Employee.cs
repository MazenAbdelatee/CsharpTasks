using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay10
{
    internal class Employee : IComparable<Employee>,ICloneable
    {
        public int Salary { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        //for tommorow solving IComparer Problem 

        public static int Compare(Employee x, Employee y)
        {
           // sort by name 
           // then by salary 

            int comparison = x.Name.CompareTo(y.Name);
            if (comparison != 0) return comparison;

            return x.Salary.CompareTo(y.Salary);

        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(Employee other)
        {
            return this.Salary.CompareTo(other.Salary);
        }

        public override string ToString() {
            return $"Emp name : {Name} , Salary : {Salary}";
        }
    }

}

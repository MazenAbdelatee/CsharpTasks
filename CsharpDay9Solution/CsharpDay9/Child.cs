using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay9
{
    internal class Child : Parent
    {
        public override decimal Salary { get => base.Salary; set => base.Salary = value; }

        public Child(decimal salary)
        {
            Salary = salary;
        }
        public void DisplaySalary()
        {
            Console.WriteLine($"Current Salary: {Salary:C}");
        }
    }
}

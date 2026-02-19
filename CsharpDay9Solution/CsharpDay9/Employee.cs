using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CsharpDay9
{
    internal class Employee
    {
        // attributes
        private int EmpId;
        private string EmpName;
        private decimal EmpSalary;


        #region Properties
        public decimal Salary
        {
            get { return EmpSalary; }
            set { EmpSalary = value < 5000 ? 5000 : value; } // Keyword : value Entered
        }

        public int Age { get; set; }

        public decimal Bonus
        {
            get { return 0.1M * EmpSalary; }
        } 
        #endregion
        public Employee(int _Id, string _Name, decimal _Salary, int _age)
        {
            EmpId = _Id;
            EmpName = _Name;
            EmpSalary = _Salary;
            Age = _age;
        }

        public override string ToString()
        {
            return $"Emp Id is {EmpId}, Emp Name is {EmpName}, Salary is {EmpSalary}, Age is {Age}";
        }

        public override bool Equals(object obj)
        {
            Employee other = (Employee)obj;
            return EmpId == other?.EmpId && EmpName == other?.EmpName;
        }
    }
}

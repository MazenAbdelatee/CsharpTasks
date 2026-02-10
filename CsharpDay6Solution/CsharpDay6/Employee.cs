using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay6
{
    internal struct Employee
    {
        #region attributes 
        private int id;
        private string name;
        private decimal salary;
        #endregion
        #region Properties 
        public int Id { set; get; }
        public string Name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        public decimal Salary { get; set; }
        #endregion


        #region Methods 
        public string GetName() { return this.Name; }
        public void SetName(string value) { this.Name = value; } 
        #endregion

    }
}

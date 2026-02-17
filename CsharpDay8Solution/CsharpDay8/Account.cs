using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay8
{
    internal struct Account
    {
        #region attributes
        private int AccountId;
        private string AccountHolder;
        private decimal balance;
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; } 
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay9
{
    internal class Person
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }

        public string Department { get; set; } 
        #endregion

        public Person(int id , string name , string department)
        {
            Id = id;
            Name = name;
            Department = department;
        }

        public override string ToString() {
            return $"Person ID : { Id } \t Name {Name} \t Department {Department} ";
        }
    }
}

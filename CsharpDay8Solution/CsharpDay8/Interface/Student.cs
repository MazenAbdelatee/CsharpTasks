using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay8.Interface
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(Student s)
        {
            Id = s.Id;
            Name = s.Name;
            Grade = s.Grade;
        }
        public Student(int _Id, string _Name , int _Grade)
        {
            Id= _Id;
            Name = _Name;
            Grade = _Grade;
        }
    }
}

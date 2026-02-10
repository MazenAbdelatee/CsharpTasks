using System;
using AM;

namespace CsharpDay6
{
    internal class Program
    {
        static void Main(string[] args)
        {
           TypeA sample = new TypeA();
            sample.H = 32;

            Employee employee = new Employee();
            employee.Id = 1;
            employee.SetName("mazen"); 
            employee.Salary = 1023.3434m;
            //Console.WriteLine(employee.id); // cannot be accessable cause it private field
        }
    }
}

using System;
using System.Collections.Generic;
using CsharpDay9.Generics;
namespace CsharpDay9
{
    public enum WeekDays {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }

    public enum  Gender  : byte  {
        Male , Female 
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            // problem one 
            WeekDays d = (WeekDays)1;
            for (int i = 1; i < 6; i++) {
                d = (WeekDays)i;
                Console.WriteLine($" {d} - {i} " );
            }

            // problem two
            Person p1 = new Person(1, " mazen " , "IT");
            Person p2 = new Person(1, " ali ", "HR");
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

            // problem three
            Child ch = new Child(1233.213m);
            ch.DisplaySalary();


            // proplem four 
            int Area = Utitlty.CalcRectangleArea(2,3);
            Console.WriteLine(Area);


            // problem five
            ComplexNumber c1 = new ComplexNumber();
            c1.Real = 3;
            c1 .Imag = 4;
            ComplexNumber c2 = new ComplexNumber();
            c2.Real = 5;
            c2.Imag = 3;
            ComplexNumber result = c1 * c2;
            Console.WriteLine(result.ToString());

            // problem six
            Console.WriteLine($"Size of modified Enum (byte): {sizeof(Gender)} bytes");
            Console.WriteLine($"Size of default Enum (int): {sizeof(WeekDays)} bytes");

            // problem seven
            double FTemp = Utitlty.CelsiusToFahrenheit(35);
            Console.WriteLine(FTemp);

            // problem eight

            Employee[] employees = { 
                new Employee(1,"ali ", 234, 30),
                new Employee(2,"mazen", 2334, 22),
                new Employee(3,"mohamed", 2343, 20),
                new Employee(4,"saad", 23343, 40)
            };
            //Console.WriteLine(Helper<Employee>.SearchArr(employees, new Employee(4, "saad", 23343, 40)));

            // Problem nine 
            int result1 = Helper<int>.Max(10, 25);
            Console.WriteLine(result1);

            double result2 = Helper<double>.Max(5.7, 3.2);
            Console.WriteLine(result2);

            string result3 = Helper<string>.Max("Ali", "Mazen");


            // problem ten 
            int[] numbers = { 1, 2, 3, 2, 5 };

            Helper<int>.ReplaceArray(numbers, 2, 99);

            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }


            string[] names = { "Ali", "Mazen", "Ali", "Sara" };

            Helper<string>.ReplaceArray(names, "Ali", "Ahmed");

            foreach (var name in names)
            {
                Console.Write(name + " ");
            }

            Rectangle rect = new Rectangle() { 
                Length = 10,
                Width = 20,
            };

            rect.Swap();



            // part two 





        }
    }
}

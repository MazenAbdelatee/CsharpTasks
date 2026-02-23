using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;


namespace CsharpDay10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //problem one
            Employee[] employees = {
                new Employee() {Id=1, Name = "Mazen " ,Salary=2332},
                new Employee() { Id=3, Name = "ali " ,Salary=3412},
                new Employee(){Id=1, Name = "Mazen " ,Salary=23432 },
                new Employee() { Id=2, Name = "halawa " ,Salary=1234},
                new Employee() {Id = 4, Name = "rayan elly mesh tay2o  ", Salary = 456},
            };

            foreach (Employee employee in employees) Console.WriteLine(employee.ToString());

            Console.WriteLine();

            GenericClass<Employee>.StaticSort(employees);
            foreach (Employee employee in employees) Console.WriteLine(employee.ToString());

            Console.WriteLine();

            // problem two
            GenericClass<Employee>.DynamicSort(employees, (a, b) => a.Salary.CompareTo(b.Salary) > 0);
            foreach (Employee employee in employees) Console.WriteLine(employee.ToString());

            //problem three 

            string[] names = { "mazen", "ali", "khaled", "saed" };
            GenericClass<string>.DynamicSort(names, (a,b)=>a?.Length>b?.Length);
            foreach (string name in names) Console.WriteLine(name);

            //problem four
            Manager[] managers = {
                new Manager(){Id=1, Name = "Mazen " ,Salary=2332 },
                new Manager(){Id=1, Name = "Mazen " ,Salary=23432 },
                new Manager(){ Id=3, Name = "ali " ,Salary=3412},
                new Manager(){ Id=2, Name = "halawa " ,Salary=1234},
                new Manager(){Id = 4, Name = "rayan elly mesh tay2o  ", Salary = 456}
            };

            // problem five
            GenericClass<Manager>.StaticSort(managers);
            foreach (Manager manager in managers) Console.WriteLine(manager.ToString());
            GenericClass<Employee>.DynamicSort(employees, (a, b) => a.Name.CompareTo(b.Name) > 0);
            foreach (Manager manager in managers) Console.WriteLine(manager.ToString());

            // Probem six
            // compare by name length first then the salary 
            GenericClass<Employee>.DynamicSort(employees, (a, b) => Employee.Compare(a, b) < 0);
            foreach (var item in employees)
            {
                Console.WriteLine(item.Salary);
            }

            // probelm seven 
            //Employee employee = GenericClass<Employee>.GetDefault();
            //Console.WriteLine(employee.ToString());

            // problem eight 
            List<string> words = new List<string> { "csharp", "delegate", "mazen" };
            List<string> upperWords = DelegateFunctions.TransformedList(words, s => s.ToUpper());
            List<string> reversedWords = DelegateFunctions.TransformedList(words, DelegateFunctions.ReverseString);

            Console.WriteLine(string.Join(", ", upperWords));    // CSHARP, DELEGATE...
            Console.WriteLine(string.Join(", ", reversedWords)); // prahsc, etageled...

            // problem nine 
            Console.WriteLine(DelegateFunctions.TestDelegate(5, 10, (a, b) => a * b));
            Console.WriteLine(DelegateFunctions.TestDelegate(5, 10, (a, b) => a + b));
            Console.WriteLine(DelegateFunctions.TestDelegate(5, 10, (a, b) => a - b));
            Console.WriteLine(DelegateFunctions.TestDelegate(5, 10, (a, b) => a / b));

            // problem ten 
            List<int> numbers = new List<int> { 1, 2, 3 };
            List<string> strings = DelegateFunctions.MapList(numbers, n => $"Number: {n}");
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }

            // problem eleven ==> يارب نخلص 
            List<int> baseNumber = new List<int> { 1, 2, 3, 4, 5 };
            List<int> squaredNumbers = DelegateFunctions.IntgerOpertions(baseNumber, x=>x*x);
            Console.WriteLine(string.Join(", ", squaredNumbers));

            // problem twelve
            Action<string> printAction = message => Console.WriteLine($"Printing: {message}");
            List<string> namesT = new List<string> { "Alice", "Bob", "Charlie" };
            DelegateFunctions.StringProcess(namesT, printAction);

            // problem 13
            List<int> numbersTest = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbers = DelegateFunctions.FilterList(numbersTest, x => x%2==0);
            Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));


            //  problem 14
            List<string> tests = new List<string>
            {
                "Mazen",
                "Mohamed",
                "Ali",
                "Ahmed",
                "Omar",
                "Salma",
                "Sara"
            };

            var startsWithM = DelegateFunctions.FilterStrings(tests, s => s.StartsWith("M"));
            Console.WriteLine("Starts with M:");
            foreach (var name in startsWithM)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("------------------");
            var containsMa = DelegateFunctions.FilterStrings(tests, s => s.ToLower().Contains("ma"));

            Console.WriteLine("Contains 'ma':");
            foreach (var name in containsMa)
            {
                Console.WriteLine(name);
            }


        }

    }
}


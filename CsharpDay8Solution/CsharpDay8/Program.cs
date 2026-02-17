using System;
using System.Collections.Generic;
using CsharpDay8.Interface;
using CsharpDay8.InterfacePartTwo;
namespace CsharpDay8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem one 
            IVehicle car = new Car();
            IVehicle bike = new Bike();

            car.StartEngine();
            bike.StartEngine();
            car.StopEngine();
            bike.StopEngine();

            // problem three
            Product p1 = new Product(1,"fruit",50);
            Product p2 = new Product(2,"Keyborad",10);
            Product p3 = new Product(3, "Mouse", 5);

            Product[] products = new Product[] { p1, p2, p3 };

            Array.Sort(products);
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ToString());
            }


            // problem four 
            Student s1 = new Student(1 , "mazen" ,14);
            Student s2 = new Student(s1);
            Student s3 = s1 ;
            s2.Name = "ali";
            s3.Name = "mohamed";
            Console.WriteLine(s1.Name);
            Console.WriteLine(s2.Name);
            Console.WriteLine(s3.Name);

            // problem five
            Robot r = new Robot();
            r.walk();

            IWalkable w = r;
            w.walk();

            // part two

            Shape sh1 = new Shape("square",25);
            Shape sh2 = new Shape("rectangle",10);
            Shape sh3 = new Shape("circle", 23);

            Shape[] shapes = { sh1, sh2, sh3 };
            
            Array.Sort (shapes);

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.ToString());
            }
        }
    }
}

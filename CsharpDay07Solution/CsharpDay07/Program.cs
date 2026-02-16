using CsharpDay07.Inhirtance;
using CsharpDay07.Interface;
using CsharpDay07.MethodChainingWithOverloading;
using System;

namespace CsharpDay07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem one
            Car c1 = new Car();
            Car c2 = new Car(1,"Honda",2300);
            Car c3 = new Car(2, "Fiat");
            Car c4 = new Car(3);

            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
            Console.WriteLine(c3.ToString());
            Console.WriteLine(c4.ToString());

            // Problem two
            Console.WriteLine(Calculator.Sum(5,3));
            Console.WriteLine(Calculator.Sum(5, 3 ,2));
            Console.WriteLine(Calculator.Sum(5.5, 3.5));

            // Problem three
            Child child = new Child(5,2,3);

            //Problem four
            Console.WriteLine(child.Product());

            //problem five

            Parent p = new Parent(5,3);
            Console.WriteLine(p.ToString());

            Console.WriteLine(child.ToString());

            // problem six 
            IShape rec = new Interface.Rectangle(5, 3);
            Console.WriteLine(rec.Area);

            //problem seven 
            IShape c = new Circle(5);
            c.PrintDetails();

            IMovable Car02 = new Car();
            Car02.move();


            // problem eight 
            File file = new File();
            file.read();
            file.write();

            //problem nine
            Shape rect = new Inhirtance.Rectangle();
            rect.Draw();

        }


    }
}

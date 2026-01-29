using System;
using System.Text;

namespace CsharpDay03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem One
            //Console.WriteLine("enter your age");
            //String age = Console.ReadLine();
            // parse method
            //try
            //{
            //    int NumAge = int.Parse(age);
            //    try {
            //        Boolean isPostive = NumAge > 0;
            //        if (isPostive)
            //        {
            //            Console.WriteLine(NumAge);
            //        }
            //        else
            //        {
            //            Console.WriteLine("you shold enter postive value and greater that zero");
            //        }
            //    }
            //    catch {
            //        Console.WriteLine("you entered invalid signed num");
            //    }
            //}
            //catch {
            //    Console.WriteLine("you entered non numiric value"); // this for non numiric value
            //}


            // convert method
            //try
            //{
            //    int NumAge = Convert.ToInt32(age);
            //    try
            //    {
            //        Boolean isPostive = NumAge > 0;
            //        if (isPostive)
            //        {
            //            Console.WriteLine(NumAge);
            //        }
            //        else
            //        {
            //            Console.WriteLine("you shold enter postive value and greater that zero");
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("you entered invalid signed num");
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("you entered non numiric value"); 
            //}



            #endregion

            #region Problem Two 
            //String Input = Console.ReadLine();
            //Boolean number = int.TryParse(Input, out int Output );
            //if (number)
            //    Console.WriteLine(Output);
            //else { Console.WriteLine("this is not numiric value"); }
            #endregion

            #region Problem Three
            //Object obj1 =  796556785;
            //Object obj2 = "hello";
            //Object obj3 = true;
            //Console.WriteLine(obj1.GetHashCode());
            //Console.WriteLine(obj2.GetHashCode());
            //Console.WriteLine(obj3.GetHashCode());
            #endregion

            #region Problem Four 
            //Point Head = new Point(5, 3, 2);
            //Point Tail = Head ;
            //Tail.z = 38;
            //Console.WriteLine(Head.z);
            #endregion

            #region Problem Five 
            //String Start = "hi";
            //Console.WriteLine(Start.GetHashCode());
            //Start+= "Willy";
            //Console.WriteLine(Start.GetHashCode());

            #endregion

            #region Problem Six
            //StringBuilder msg = new StringBuilder("Hi");
            //Console.WriteLine(msg.GetHashCode());
            //msg.Append("Willy");
            //Console.WriteLine(msg.GetHashCode());
            #endregion

            #region Problem Seven 
            //int y =int.Parse(Console.ReadLine());
            //int x =int.Parse(Console.ReadLine());
            //Console.WriteLine("Sum X+Y is =  " + " " + "X= " + x + " " + "Y= "+ " "+ y + " = " + (x+y));
            //Console.WriteLine($"The sum : {x} + {y} = {x+y}");
            //Console.WriteLine(String.Format("Sum x+y : {0} + {1} = {2} ",x,y , x+y));

            #endregion

            #region Problem Eight 
            //StringBuilder Str = new StringBuilder("Hello World !");
            //Str.Append(": ali");
            //Console.WriteLine(Str);
            //Str.Replace("ali", "mazen");
            //Console.WriteLine(Str);
            //Str.Insert(5, "go away ");
            //Console.WriteLine(Str);

            #endregion 
        }
    }
}

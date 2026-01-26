using System;

namespace CsharpDay02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem One
            ////one line comment
            //int x = 10;
            //int y = 20;
            //int sum = x + y;
            //Console.WriteLine(sum);
            /*
             * multiline comment 
             *  int x = 10;
                int y = 20;
                int sum = x + y;
                Console.WriteLine(sum);
             */
            // the one line comment here will corrupt the logic but the multiline will make the code ignored 
            #endregion
            #region  Question One 
            // ctrl + k + c for comment
            // ctrl + k + u for uncomment 
            // ctrl + / for fast shortcut 
            #endregion
            #region Problem Two 
            //int x = "10"; // this is putting string value type in numirc value type should be alterd to String or removing the "" 
            int x = 15 ;
            int y = 4 ;// added 
            Console.WriteLine(x+y); // there is no variable y to see just add the new variable or removing it from expression
            #endregion
            #region Problem Three
            String FullName = "Mazen Abdelateef";
            short age = 21;
            decimal salary = 234.324m;
            Boolean isStudent = true;
            #endregion
            #region Problem Four 
            Point p1 = new Point(x, y);
            Point p2 = p1;
            p1.x = 49;
            Console.WriteLine(p2.x);
            #endregion
            #region Problem Five 
            int sum = x + y;
            int differnece = x - y;
            int product = x * y;
            double division = x / y;
            int reminder= x % y;
            #endregion
            #region Problem Six 
            if (x > 10 && x % 2 == 0) {
                Console.WriteLine(" the number is greater than 10 and even ");
            }
            #endregion
            #region Problem Seven 
            double num = Convert.ToDouble(Console.ReadLine());
            int disaster = (int)num; // can't do implict casting
            Console.WriteLine(disaster);
            #endregion
            #region Problem Eight
            Console.WriteLine("Please Enter your Age");
            String UserAge = Console.ReadLine();
            int NumricValue = int.Parse(UserAge);
            if (NumricValue > 0) {
                Console.WriteLine("you are not joking ");
            }
            #endregion
            #region Problem Nine 
            int test = 10;
            test++; // test will be printed  10 and after that will be 11
            Console.WriteLine(test);
            test--; // test will be 10 then and after that it will be printed 
            Console.WriteLine(test);
            #endregion

            
           
        }
        
    }
}

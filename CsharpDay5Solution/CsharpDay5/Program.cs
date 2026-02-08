using System;
using System.Linq;
using System.Text;

namespace CsharpDay5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem one 
            //try
            //{
            //    bool flagOne = int.TryParse(Console.ReadLine(), out int x);
            //    bool flagTwo = int.TryParse(Console.ReadLine(), out int y);
            //    if (flagOne && flagTwo )
            //    {
            //        int z = x / y;
            //        Console.WriteLine(z);
            //    }
            //}
            //catch (DivideByZeroException Ex) { Console.WriteLine(Ex.Message); }
            //finally {
            //    Console.WriteLine("Operation Complete");
            //}
            #endregion

            #region Problem three 
            //int? x =int.Parse(Console.ReadLine() ?? "10");
            //Console.WriteLine(x.Value); // the value of the variable 
            //Console.WriteLine(x.HasValue);// check if there is value in variable 
            #endregion

            #region Problem four 
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //try
            //{
            //    Console.WriteLine(numbers[5]);
            //}
            //catch (IndexOutOfRangeException Ex) { Console.WriteLine(Ex.Message); }
            #endregion

            #region Problem five 
            //int[,] numbers = new int[3,3];
            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers.GetLength(1) ; j++)
            //    {
            //         Console.Write($"Enter the number for Row {i+1} and Column {j+1}: \t ");
            //        if(int.TryParse(Console.ReadLine(), out int x)){ 
            //            numbers[i,j] = x;
            //        }
            //    }
            //}
            //for (int i = 0; i <numbers.GetLength(0) ; i++)
            //{
            //    int rowSum = 0;
            //    for (int c = 0; c < numbers.GetLength(1); c++) rowSum += numbers[i, c];
            //    Console.WriteLine($"Row {i} Sum: {rowSum}");
            //}


            //for (int c = 0; c < 3; c++) 
            //{
            //    int colSum = 0;
            //    for (int r = 0; r < 3; r++) 
            //    {
            //        colSum += numbers[r, c];
            //    }
            //    Console.WriteLine($"Column {c} Sum: {colSum}");
            //}
            #endregion



            #region Problem six
            //int[][] jaggedArray = new int[3][];
            //for (int i = 0; i < jaggedArray.GetLength(0); i++) {

            //    Console.WriteLine($"Ente the Number Of Elements for Row {i + 1}");
            //    if (int.TryParse(Console.ReadLine(), out int NumberOfElements)) {

            //        jaggedArray[i] = new int[NumberOfElements];
            //        for (int j = 0; j < NumberOfElements; j++) {
            //            Console.Write($"Row {i}, Element {j}: ");
            //            if (int.TryParse(Console.ReadLine(), out int x)) {

            //                jaggedArray[i][j] = x;
            //            }
            //        }

            //    }
            //}
            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    Console.Write($"Row {i} ({jaggedArray[i].Length} elements): ");
            //    foreach (int item in jaggedArray[i])
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region Problem seven 

            //string input = Console.ReadLine();
            //string? UserName = string.IsNullOrEmpty(input) ? null : input ;
            //Console.WriteLine(UserName!.Length);


            #endregion

            #region Problem Eight
            //int num = 123;
            //Object myObj=num;

            //try
            //{
            //    byte Unboxing = (byte)myObj;

            //}
            //catch (InvalidCastException ex) { Console.WriteLine(ex.Message); }
            #endregion

            #region Problem nine
            //SumAndMulti(2, 4, out int sum, out int product);
            //Console.WriteLine(sum + " " +product );
            #endregion

            #region Problem ten
            //PrintNTimes(n:5,inp:"no way you idiot");
            #endregion


            #region Problem eleven 
            //int[]? nullableArray = { 1, 2, 4 };
            //int? length = nullableArray?.Length;
            #endregion
            #region Problem twelve
            //Console.WriteLine(SumArray(1,2,3,4));
            //int[] testTwo = {1,2,3,4};
            //Console.WriteLine(SumArray(testTwo));

            #endregion


            // part 2
            #region Problem one

            //if (int.TryParse(Console.ReadLine(), out int number))
            //{
            //    int counter = number > 0 ? number : 0;
            //    for (int i = 1; i < counter; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //} 
            #endregion

            #region Problem two
            //Console.WriteLine("please enter intger number");
            //bool flag = int.TryParse(Console.ReadLine(), out int number);
            //if (flag)
            //{
            //    for (int i = 0; i <= 12; i++)
            //    {
            //        Console.WriteLine(number * i);
            //    }
            //}
            #endregion


            #region Problem three
            //Console.WriteLine("please enter intger number");
            //bool flag = int.TryParse(Console.ReadLine(), out int number);
            //if (flag)
            //{
            //    for (int i = 0; i <= number; i++)
            //    {
            //        if (i % 2 == 0)
            //            Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region Problem four 
            //int baseNum = Convert.ToInt32(Console.ReadLine());
            //int powerNum = Convert.ToInt32(Console.ReadLine());

            //int result = baseNum;
            //for (int i = 1; i <= powerNum; i++)
            //{
            //    result *= baseNum;
            //}
            //Console.WriteLine(result);
            #endregion

            #region Problem five
            //Console.WriteLine("Enter your text to be reversed");
            //string textInput = Console.ReadLine();
            //StringBuilder reversedText = new StringBuilder("");
            //for (int i = textInput.Length-1; i >= 0; i--) {
            //    reversedText.Append(textInput[i]);
            //}
            //Console.WriteLine(reversedText); 
            #endregion

            #region Problem six

            //Console.Write("Input: ");
            //string input = Console.ReadLine();
            //char[] digits = input.ToCharArray();
            //Array.Reverse(digits);
            //string output = new string(digits);
            //Console.WriteLine($"Output:{output} "); 
            #endregion

            #region Problem seven
            Console.Write("Input: ");
            //string input = Console.ReadLine();
            //var reversedWords = input.Split(' ').Reverse();
            //Console.WriteLine($"Output: {string.Join(" ", reversedWords)}"); 
            #endregion



        }
        #region Problem two 
        //public static void TestDefensiveCode()
        //{
        //    int X, Y, Z;

        //    do
        //    {
        //        Console.WriteLine("Enter first Number : ");
        //    }
        //    while (!int.TryParse(Console.ReadLine(), out X) || X <= 0);
        //    do
        //    {
        //        Console.WriteLine("Enter Second Number : ");
        //    }
        //    while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 1);

        //    Z = X / Y;
        //    Console.WriteLine(Z);
        //}
        #endregion


        #region Problem nine 
        public static void SumAndMulti(int numOne , int numTwo, out int sum , out int product) {
            sum = numOne + numTwo;
            product = numTwo*numOne;
        }
        #endregion



        #region Problem ten
        public static void PrintNTimes(string inp , int n = 5) {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(inp);
            }
        }
        #endregion


        #region Problem tewlve 
        static int SumArray(params int[] values)
        {
            int total = 0;
            foreach (int val in values)
            {
                total += val;
            }
            return total;
        }
        #endregion 
    }
}



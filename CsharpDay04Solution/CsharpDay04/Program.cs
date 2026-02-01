using System;

namespace CsharpDay04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem one 
            //int[] arr1;
            //arr1 = new int[3];
            //arr1[0] = 1;
            //arr1[1] = 2;
            //arr1[2] = 3;
            //arr1[3] = 4;
            //Console.WriteLine(arr1[3]);
            //int [] arr2=new int[3] {1,2,4};
            //int [] arr3 ={3,2,4};
            //for (int i = 0; i < arr3.Length; i++)
            //    Console.WriteLine(arr3[i]);
            #endregion


            #region Problem two 
            ////shallow copy
            //byte[] origin = { 1, 3, 4 };
            //byte[] ShallowCopy = origin;
            //ShallowCopy[2] = 34;
            //Console.WriteLine(origin[2]);

            ////deep copy 
            //byte[] DeepCopy = (byte[]) origin.Clone();
            //DeepCopy[2] = 21;
            //Console.WriteLine(origin[2]);
            #endregion


            #region Problem three 
            //int[,] StudentsGrades = new int[3, 3];
            //// filling the array
            //for (int i = 0; i < StudentsGrades.GetLength(0); i++) {
            //    for (int j = 0; j < StudentsGrades.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter the student {i+1} grade in course {j+1} ");
            //        String inp = Console.ReadLine();
            //        bool flag=int.TryParse(inp ,out StudentsGrades[i,j]);
            //    }

            //}
            //// display the values 
            //for (int i = 0; i < StudentsGrades.GetLength(0); i++)
            //{
            //    for (int j = 0; j < StudentsGrades.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"the grade of student {i+1} in course {j+1} is : {StudentsGrades[i,j]}" );
            //    }

            //}
            #endregion


            #region Problem four
            //int[] numbers = { 45, 12, 78, 33, 90 };
            //Console.WriteLine("Original Array: " + string.Join(", ", numbers));


            //Array.Sort(numbers);
            //Console.WriteLine("After Sort: " + string.Join(", ", numbers));


            //Array.Reverse(numbers);
            //Console.WriteLine("After Reverse: " + string.Join(", ", numbers));

            //int index = Array.IndexOf(numbers, 78);
            //Console.WriteLine($"Index of 78: {index}");

            //int[] copyArray = new int[5];
            //Array.Copy(numbers, copyArray, 5);
            //Console.WriteLine("Copied Array: " + string.Join(", ", copyArray));

            //Array.Clear(numbers, 0, 2); 
            //Console.WriteLine("After Clear (0, 2): " + string.Join(", ", numbers));
            #endregion


            #region Prolem five 
            //int[] arr = { 37, 41, 56, 24, 12,34 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} \t");
            //}
            //Console.WriteLine(" ");
            //foreach (int item in arr)
            //{
            //    Console.Write($"{item} \t");
            //}
            //Console.WriteLine(" ");
            //byte j = 0;
            //while (j<arr.Length) {

            //    Array.Reverse(arr);
            //    Console.Write($"{arr[j]} \t");
            //    j++;

            //}
            #endregion


            #region Problem six
            //do { 
            //    String inp = Console.ReadLine();
            //    bool flag = int.TryParse(inp, out int number);
            //    if (flag)
            //    {
            //        if (number < 0 || number % 2 == 0) {

            //            Console.WriteLine("you entered not odd Postive value");
            //        }

            //    }
            //}
            //while (true);
            #endregion


            #region Problem seven 
            //int[,] salaries = { { 1, 3999 }, { 2, 3444 }, { 4, 3434 } };
            //for (int i = 0; i < salaries.GetLength(0); i++) {
            //    for (int j = 0; j < salaries.GetLength(1); j++) {

            //        Console.Write($"  {salaries[i,j] } \t" );
            //    }
            //    Console.WriteLine(" ");
            //}
            #endregion


            #region Problem eight 
            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int forSum = 0;
            //int foreachSum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    forSum += numbers[i];
            //}

            //foreach (int num in numbers)
            //{
            //    foreachSum += num;
            //}
            //Console.WriteLine($"Sum using for: {forSum}");
            //Console.WriteLine($"Sum using foreach: {foreachSum}");
            #endregion

            #region Problem nine
            //Console.Write("Enter month number (1-12): ");
            //if (int.TryParse(Console.ReadLine(), out int month))
            //{
                
            //    if (month == 1) Console.WriteLine("January");
            //    else if (month == 2) Console.WriteLine("February");
                
            //    else Console.WriteLine("Invalid Month");

                
            //    switch (month)
            //    {
            //        case 1: Console.WriteLine("January"); break;
            //        case 2: Console.WriteLine("February"); break;
            //        case 3: Console.WriteLine("Marcg");break;
            //        default: Console.WriteLine("Invalid Month"); break;
            //    }
            //}
            #endregion

            #region Problem ten
            int[] data = { 5, 2, 8, 2, 9 };
            Array.Sort(data); 
            int first = Array.IndexOf(data, 2);     
            int last = Array.LastIndexOf(data, 2);  
            Console.WriteLine($"First index of 2: {first}, Last index: {last}");
            #endregion
        }
    }
}

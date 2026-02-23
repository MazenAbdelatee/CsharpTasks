using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CsharpDay10
{


    public delegate string TransformStringDelegate(string MyString);
    public delegate int IntgerOperation(int x, int y);
    public delegate R ConvertToR<T, R>(T input);

    public class DelegateFunctions
    {
        #region IntegerOperation
        public static List<R> MapList<T, R>(List<T> inputs, ConvertToR<T, R> transformer)
        {
            List<R> results = new List<R>();
            foreach (var item in inputs)
            {
                results.Add(transformer(item));
            }
            return results;
        }
        public static int TestDelegate(int First, int Second, IntgerOperation operation)
        {
            return operation(First, Second);
        }
        public static List<int> IntgerOpertions(List<int> IntgerList, Func<int, int> operation)
        {
            List<int> resultList = new List<int>();
            foreach (var item in IntgerList)
            {
                resultList.Add(operation(item));
            }
            return resultList;
        }
        public static List<int> FilterList(List<int> inputList, Predicate<int> condition)
        {
            List<int> filteredList = new List<int>();

            foreach (int number in inputList)
            {
                if (condition(number))
                {
                    filteredList.Add(number);
                }
            }

            return filteredList;
        }

        #endregion 

        #region StringOperations
        public static string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }
        public static List<string> TransformedList(List<string> StringList, TransformStringDelegate TransformFunc)
        {
            List<string> TransformedList = new List<string>();

            foreach (string word in StringList)
            {
                TransformedList.Add(TransformFunc(word));
            }
            return TransformedList;
        }
        public static void StringProcess(List<string> input, Action<string> action)
        {
            foreach (var item in input) { action(item); }
        }
        public static List<string> FilterStrings(List<string> list, Func<string, bool> condition)
        {
            List<string> result = new List<string>();

            foreach (string item in list)
            {
                if (condition(item))
                {
                    result.Add(item);
                }
            }

            return result;
        } 
        #endregion
    }
}

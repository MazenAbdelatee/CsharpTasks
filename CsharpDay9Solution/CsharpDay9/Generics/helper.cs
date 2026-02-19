using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay9.Generics
{
    static class Helper<T> where T : IComparable<T>
    {
        public static int SearchArr(T[] Arr, T Value)
        {
            for (int i = 0; i < Arr?.Length; i++)
            {
                if (Value.Equals((Arr[i])))
                    return i;
            }
            return -1;
        }

        public static T Max(T First, T Second)
        {
            return (First.CompareTo(Second) > 0) ? First : Second;
        }

        public static void ReplaceArray(T[] WantedArray, T target, T AlterValue)
        {
            if (WantedArray == null)
            {
                return;
            }
            for (int i = 0; i < WantedArray?.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(WantedArray[i], target))
                {
                    WantedArray[i] = AlterValue;
                }

            }
        }

        public static T[] ReverseArray(T[] Target ) {
            T[] ReversedArray = new T[Target.Length];
            int j = Target.Length - 1;
            for (int i = 0; i < Target.Length; i++)
            {
                ReversedArray[i] = Target[j];
                j--;
            }
            return ReversedArray;
        }

    }
}

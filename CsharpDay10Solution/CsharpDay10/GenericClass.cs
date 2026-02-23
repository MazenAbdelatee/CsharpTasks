using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay10
{

    internal class GenericClass<T> where T : IComparable<T> 
    {
        public static void Swap(ref T First, ref T Second) { 
            T temp = First;
            First = Second;
            Second = temp; 
        }

        public static void DynamicSort(T[] items ,Func<T,T,bool> compareFunc ) {
            for (int i = 0; i < items.Length - 1; i++) {
                for (int j = 0; j < items.Length-1-i; j++)
                {
                    if (compareFunc(items[j], items[j+1])) {

                        Swap(ref items[j],ref items[j + 1]);
                    }
                }
            }
        }

        public static void StaticSort(T[] items)
        {

            for (int i = 0; i < items.Length - 1; i++)
            {
                for (int j = 0; j < items.Length - 1 - i; j++)
                {
                    if (items[j].CompareTo(items[j+1]) > 0)
                    {

                        Swap(ref items[j], ref items[j + 1]);
                    }
                }

            }
        }

        public static T GetDefault() { return default(T); }

    }


}


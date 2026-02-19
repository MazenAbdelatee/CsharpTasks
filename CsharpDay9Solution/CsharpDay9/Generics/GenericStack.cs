using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay9.Generics
{
    internal class GenericStack <T>
    {
        // stack is first in last out 
        private T[] GenericArray ;
        private int count;
        public GenericStack()
        {
            length = 0;
            GenericArray = new T[length];
        }

        public void Push(T Element) {
            length++;
            GenericArray[length] = Element;
        }

        public T Pop() { 
            length--;
            return GenericArray[length];

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay07.Interface
{
    internal class File : IReadable, IWriteable
    {
        public void read()
        {
            Console.WriteLine("this is Read function ");
        }

        public void write()
        {
            Console.WriteLine("this is Write function");
        }
    }
}

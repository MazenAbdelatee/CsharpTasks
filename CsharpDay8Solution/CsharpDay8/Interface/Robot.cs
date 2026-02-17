using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CsharpDay8.Interface
{
    internal class Robot :  IWalkable
    {

        public void walk() {
            Console.WriteLine("the robot walking");
        }

        void IWalkable.walk() {
            Console.WriteLine("the interface walking");
        }
    }

}

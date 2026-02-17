using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay8.Interface
{
    internal class Car : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Car Engine running");
        }

        public void StopEngine()
        {
            Console.WriteLine("Car engine Stopped");
        }
    }
}

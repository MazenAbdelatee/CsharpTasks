using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay8.Interface
{
    internal class Bike : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Bike Starting");
        }

        public void StopEngine()
        {
            Console.WriteLine("Bike Stopped");
        }
    }
}

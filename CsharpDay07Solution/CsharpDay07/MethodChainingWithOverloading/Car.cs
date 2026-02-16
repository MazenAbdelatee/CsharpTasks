using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpDay07.Interface;

namespace CsharpDay07.MethodChainingWithOverloading
{
    internal class Car : IMovable
    {
        #region Attributes
        private int id;
        private string brand;
        private int price;
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
        #endregion

        #region Constructor
        public Car() { }
        public Car(int _Id, string _Brand, int _Price)
        {
            id = _Id;
            brand = _Brand;
            price = _Price;
        }
        public Car(int _Id, string _Brand) : this(_Id, _Brand, 32000) { }
        public Car(int _Id) : this(_Id, "BMW", 4000_000) { }
        #endregion

        #region Mehtods
        public override string ToString()
        {
            return $"The Car ID : {id} \n and Brand : {brand} \n and Price : {price}";
        }

        public void move()
        {
            Console.WriteLine("the car moving"); 
        }
        #endregion
    }
}

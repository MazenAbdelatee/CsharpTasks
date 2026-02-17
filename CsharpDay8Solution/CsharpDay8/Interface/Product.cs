using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay8.Interface
{
    internal class Product : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(int _Id , string _Name , decimal _Price)
        {
            Id = _Id ;
            Name = _Name ;
            Price = _Price ;
        }
        public int CompareTo(object obj)
        {
            Product PassedProduct = (Product) obj;
            return Price.CompareTo(PassedProduct?.Price);
        }

        public override string ToString() {
            return$"Product { Name  } and Price {Price } ";
        }
    }
}

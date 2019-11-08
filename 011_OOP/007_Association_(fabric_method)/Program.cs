using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Association__fabric_method_
{

    class Product
    {
        public Product()
        {
            Console.WriteLine("Product");
        }
    }

    class Fabric
    {
        public Product ReturnProduct()
        {
            return new Product();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fabric fabric = new Fabric();
            Product product = fabric.ReturnProduct();
            
        }
    }
}

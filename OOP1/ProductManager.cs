using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName +" eklendi." );
        }

        public void Update (Product product)
        {
            Console.WriteLine(product.ProductName +" güncellendi.");
        }
        public int Topla(int s1, int s2)
        {
            return s1 + s2;
        }
        public void Topla2(int s1, int s2)
        {
            Console.WriteLine(s1+s2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Couser11.Entities;

namespace Couser11
{
    internal class Program
    {
        //Fazer um programa que,apartir de uma lista de produtos,remova da lista somente
        //aqueles cujo preço minimo seja 100
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv" , 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("Hd case", 80.00));

            // list.RemoveAll(p => p.Price >= 100.0);
            list.RemoveAll(ProductText);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
        public static bool ProductText(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}

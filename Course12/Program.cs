using System;
using System.Collections.Generic;
using Course12.Entities;

namespace Course12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa que,a partir de uma lista de produtos,aumente os preços dos produtos a 10%
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD case", 80.90));

            list.ForEach(UpdatePrice);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }

    }
}

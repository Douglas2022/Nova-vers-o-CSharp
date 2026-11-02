using Course13.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


//Fazer um programa que,a partir de uma lista de produtos.Letras maíscula gere uma nova lista contendo os nomes dos produtos em caixa alta.

namespace Course13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 900.00));
            list.Add(new Product("Tablet", 900.00));
            list.Add(new Product("HD case", 900.00));
            //Delagate;Colocar a expressao lambida em in line.
           

            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
        /*  static string NameUpper(Product P)
         {
              return P.Name.ToUpper();
         }
        */
    }
}

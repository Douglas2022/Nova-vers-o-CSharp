using Couser2.Sevices;
using System;
using System.Collections.Generic;
using Couser2.Entities;
using System.Globalization;


namespace Couser2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Digite N: ");
            int n = int.Parse(Console.ReadLine());  

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1],CultureInfo.InvariantCulture);
                list.Add(new Product(name,price));
            }

            CalculationService calationService = new CalculationService();

            Product max = calationService.Max(list);
            
            Console.WriteLine("Max");
            Console.WriteLine(max);

        }
    }
}

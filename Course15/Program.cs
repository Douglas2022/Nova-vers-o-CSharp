using System;
using System.Linq;
using System.Collections.Generic;
using Course15.Entities;

namespace Course15
{
    internal class Program
    {
        //Função auxiliar
        static void Print<T>(string menssage,IEnumerable<T> collections)
        {
            Console.WriteLine(menssage);
            foreach(T obj in collections)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() {Id = 1,Name = "Tools",Tier = 2};
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer",Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer",Price = 900.0, Category = c3 },
                new Product() { Id = 3, Name = "TV",Price = 1700.0, Category = c2 },
                new Product() { Id = 4, Name = "Notebook",Price = 1800.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw",Price = 1500.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet",Price = 900.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera",Price = 300.0, Category = c1 },
                new Product() { Id = 8, Name = "Printer",Price = 200.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook",Price = 1400.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound bar",Price = 1200.0, Category = c3 },
                new Product() { Id = 11, Name = "Level",Price = 1500.0, Category = c1 }
            };

            var r1 = products.Where(P => P.Category.Tier == 1 && P.Price < 900.0 );
            Print("Tier 1 price < 900:",r1);

            var r2 = products.Where(P => P.Category.Name == "Tools").Select(P => P.Name);
            Print("Name of products category tools", r2);

            var r3 = products.Where(P => P.Name[0] == 'C').Select(P => new {P.Name,P.Price,CategoryName = P.Category.Name});
            Print("Nome começado com 'C' e objetos anonimos ",r3);
        }
    }
}

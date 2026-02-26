using System;
using System.Linq;
using System.Collections.Generic;
using Course15.Entities;
using System.Runtime.InteropServices;

namespace Course15
{
    internal class Program
    {
        //Função auxiliar
        static void Print<T>(string menssage, IEnumerable<T> collections)
        {
            Console.WriteLine(menssage);
            foreach (T obj in collections)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Products> products = new List<Products>()
            {
                new Products() { Id = 1, Name = "Computer",Price = 1100.0, Category = c2 },
                new Products() { Id = 2, Name = "Hammer",Price = 900.0, Category = c3 },
                new Products() { Id = 3, Name = "TV",Price = 1700.0, Category = c2 },
                new Products() { Id = 4, Name = "Notebook",Price = 1800.0, Category = c2 },
                new Products() { Id = 5, Name = "Saw",Price = 1500.0, Category = c1 },
                new Products() { Id = 6, Name = "Tablet",Price = 900.0, Category = c2 },
                new Products() { Id = 7, Name = "Camera",Price = 300.0, Category = c1 },
                new Products() { Id = 8, Name = "Printer",Price = 200.0, Category = c3 },
                new Products() { Id = 9, Name = "MacBook",Price = 1400.0, Category = c2 },
                new Products() { Id = 10, Name = "Sound bar",Price = 1200.0, Category = c3 },
                new Products() { Id = 11, Name = "Level",Price = 1500.0, Category = c1 }
            };
            //Demo - LINQ com notação similar SQL

            // var r1 = products.Where(P => P.Category.Tier == 1 && P.Price < 900.0);
            var r1 =
                 from p in products
                 where p.Category.Tier == 1 && p.Price < 900.0
                 select p;

            Print("Tier 1 price < 900:", r1);

            //var r2 = products.Where(P => P.Category.Name == "Tools").Select(P => P.Name);
            var r2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;
            Print("Name of products category tools", r2);

            //var r3 = products.Where(P => P.Name[0] == 'C').Select(P => new { P.Name, P.Price, CategoryName = P.Category.Name });
            var r3 =
                from p in products
                where p.Name[0] == 'C'
                select new
                {
                    p.Name,
                    p.Price,
                    CategoryName = p.Category.Name
                };
            Print("Nome começado com 'C' e objetos anonimos ", r3);

            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(P => P.Price).ThenBy(P => P.Name);
            var r4 =
                from p in products
                where p.Category.Tier == 1
                orderby p.Name
                orderby p.Price
                select p;

            Print("Tier 1 ordenado por preço e nome: ", r4);

           // var r5 = r4.Skip(2).Take(4);
           var r5 = 
                (from p in r4 select p).Skip(2).Take(4);
            Print("Tier 1 ordenado por preço e nome: Pula 2 e pega 4 ", r5);

            //var r6 = products.FirstOrDefault();

            Console.WriteLine("First or default teste1: " + r6);

            var r7 = products.Where(P => P.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("Primeiro or default: " + r7);
            Console.WriteLine();

            var r8 = products.Where(P => P.Id > 3).FirstOrDefault();
            Console.WriteLine("Single or default test1:" + r8);

            var r9 = products.Where(P => P.Id > 30).SingleOrDefault();
            Console.WriteLine("Single or default test2:" + r9);
            Console.WriteLine();

            var maxPrice = products.Max(p => p.Price);
            var totalPrice = products.Sum(p => p.Price);
            var minPrice = products.Min(p => p.Price);
            var averagePrice = products.Average(p => p.Price);

            Console.WriteLine("Max price: " + maxPrice);
            Console.WriteLine("Min price: " + minPrice);
            Console.WriteLine("Soma dos preços: " + totalPrice);
            Console.WriteLine("Média dos preços: " + averagePrice);

            var r12 = products.Where(p => p.Category.Id == 1);

            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 avered price: " + r14);

            var r15 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 agregate sum: " + r15);
            // var r10 = products.Any() ? products.Max(p => p.Price) : 0;

            var r16 = products.GroupBy(p => p.Category);
            foreach (IGrouping<Category, Products> group in r16)
            {
                Console.WriteLine("category: " + group.Key.Name + ":");
                foreach (Products p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }

        }
    }
}

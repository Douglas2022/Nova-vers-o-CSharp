using System;
using Couser3.Entities;

namespace Couser3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "Maria@gmail.com" };
            Client b = new Client { Name = "Cathrina", Email = "Maria@gmail.com" };
            //Client b = new Client { Name = "Cathrina", Email = "Cat@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b); //False
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

        }
    }
}

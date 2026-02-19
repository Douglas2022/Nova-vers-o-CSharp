using Course9.Entities;
using System;

namespace Course9
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            double a = 10; double b = 12;

            double result = CalculateServices.Sum(a, b);
            double result0 = CalculateServices.Max(a, b);
            double resulto = CalculateServices.Square(a);
            Console.WriteLine("Soma é de: " + result);
            Console.WriteLine("Máximo de 10 é: " + result0);
            Console.WriteLine("Raiz de (a) é: " + resulto);
        }
    }
}

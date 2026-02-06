using Couser2.Sevices;
using System;
using System.Collections.Generic;


namespace Couser2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Console.Write("Digite N: ");
            int n = int.Parse(Console.ReadLine());  

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                list.Add(x);
            }

            CalculationService calationService = new CalculationService();

            int max = calationService.Max(list);
            
            Console.WriteLine("Max");
            Console.WriteLine(max);

        }
    }
}

using Course9.Entities;
using System;

namespace Course9
{
    delegate double BinaryNumericOperation(double n1,double n2);
    internal class Program
    {
       
        static void Main(string[] args)
        {
            double a = 10; double b = 12;

            BinaryNumericOperation op = CalculateServices.Sum;
            BinaryNumericOperation opi = CalculateServices.Max;
           

            //double result = CalculateServices.Sum(a, b);
            //double result0 = CalculateServices.Max(a, b);
            //double resulto = CalculateServices.Square(a);
            //Console.WriteLine("Soma é de: " + result);
            //Console.WriteLine("Máximo de 10 é: " + result0);
            //Console.WriteLine("Raiz de (a) é: " + resulto);

            double result = op(a,b);
            Console.WriteLine(result);

            double resulte = opi(a, b);
            Console.WriteLine(resulte);

          
        }
    }
}

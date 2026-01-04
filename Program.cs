using System;
using BaseGeometrica.Model.Entities;
using BaseGeometrica.Enums.Model;
using BaseGeometrica.Entities;

namespace BaseGeometrica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ishape S1 = new Cicle() { Radiums = 2.0,Color = Color.White};
            Ishape S2 = new Retangulo() { Widht = 3.5,Height = 4.2,Color = Color.Black};
            Console.WriteLine(S1);
            Console.WriteLine(S2);
        }
    }
}

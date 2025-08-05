using System;
using System.Globalization;
using Xadrez1.Entities;

namespace Xadrez1
{
    internal class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.WriteLine("Car model: ");
            string model = Console.ReadLine();

            Console.WriteLine("Pickup (dd/MM/yyyy hh:ss): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "(dd/MM/yyyy HH:mm)", CultureInfo.InvariantCulture);

            Console.WriteLine("Return (dd/MM/yyyy hh:ss): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "(dd/MM/yyyy HH:mm)", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish,new Vehicle(model));
        }

    }
}

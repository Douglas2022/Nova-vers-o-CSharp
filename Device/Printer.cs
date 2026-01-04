using System;

namespace BaseGeometrica.Devices
{
    internal class Printer : Device
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }

        public void Print(string document)
        {
            Console.WriteLine("Printer print: " + document);
        }
    }
}

using System;
using BaseGeometrica.Device;
using BaseGeometrica.Devices;

namespace BaseGeometrica
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Printer P = new Printer() { SerialNumber = 1030};
            P.ProcessDoc("My letter");
            P.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 1030 };
            s.ProcessDoc("My email");
            Console.WriteLine(s.Scan());

            ComboDevice C = new ComboDevice() { SerialNumber = 3921 };
            C.ProcessDoc("My dissertação");
            C.Print("My dissertação");
            Console.WriteLine(C.Scan());

        }
    }
}

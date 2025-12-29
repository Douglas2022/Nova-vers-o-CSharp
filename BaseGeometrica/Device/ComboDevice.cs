using BaseGeometrica.Device;
using System;

namespace BaseGeometrica.Devices
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Combo device processing " + document);
        }

        internal void Print(string v)
        {
            throw new NotImplementedException();
        }

        void IPrinter.Print(string document)
        {
            Console.WriteLine("Combo device print " + document);
        }

        string IScanner.Scan()
        {
            return "Combo device scan result";
        }
    }
}

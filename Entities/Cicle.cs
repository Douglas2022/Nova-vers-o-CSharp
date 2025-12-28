
using BaseGeometrica.Entities;
using System;
using System.Globalization;

namespace BaseGeometrica.Model.Entities
{
    internal class Cicle : AbstrateShape
    {
        public double Radiums { get; set; }

        public override double Area()
        {
           return Math.PI * Radiums * Radiums;
        }
        public override string ToString()
        {
            return "Cicle color  = "
                + Color
                + ",radiums"
                + Radiums.ToString("F2", CultureInfo.InvariantCulture)
                + ",Area"
                + Area().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}

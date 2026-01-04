using BaseGeometrica.Entities;
using System;
using System.Globalization;

namespace BaseGeometrica.Model.Entities
{
    class Retangulo : AbstrateShape
    {
        public double Widht { get; set; }
        public double Height { get; set; }

        public override Double Area()
        {
            return Widht * Height;

        }
        public override String ToString()
        {
            return "Retangule color = "
            + Color
            + ",Widht = "
            + Widht.ToString("F2", CultureInfo.InvariantCulture)
            + ",Reight = "
            + Height.ToString("F2", CultureInfo.InvariantCulture)
            + ",Aréa = "
            + Area().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
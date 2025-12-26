using BaseGeometrica.Enums.Model;

namespace BaseGeometrica.Model.Entities
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}

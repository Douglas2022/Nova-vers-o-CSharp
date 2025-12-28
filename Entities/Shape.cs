using BaseGeometrica.Enums.Model;

namespace BaseGeometrica.Model.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}

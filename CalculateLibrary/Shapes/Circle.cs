using CalculateShapeLibrary.Interfaces.Shapes;

namespace CalculateShapeLibrary.Shapes
{
    public sealed class Circle : ICircle
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get;
        }
    }
}

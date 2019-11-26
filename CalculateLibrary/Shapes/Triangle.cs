using System;
using CalculateShapeLibrary.Interfaces.Shapes;

namespace CalculateShapeLibrary.Shapes
{
    public sealed class Triangle : ITriangle
    {
        public Triangle(
            double a,
            double b,
            double c
            )
        {
            if (a >= b + c
                || b >= a + c
                || c >= a + b
                )
            {
                throw new Exception("Это не треугольник");
            }

            A = a;
            B = b;
            C = c;
        }

        public double A
        {
            get;
        }

        public double B
        {
            get;
        }

        public double C
        {
            get;
        }
    }
}

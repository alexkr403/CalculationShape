namespace CalculateShapeLibrary.Interfaces.Shapes
{
    /// <summary>
    /// Площадь круга
    /// </summary>
    internal interface ICircleSquare
    {
        /// <summary>
        /// Вычислить площадь круга
        /// </summary>
        double Calculate(double radius);
    }

    /// <summary>
    /// Площадь треугольника
    /// </summary>
    internal interface ITriangleSquare
    {
        /// <summary>
        /// Вычислить площадь треугольника
        /// </summary>
        double Calculate(
            double a,
            double b,
            double c
            );
    }
}

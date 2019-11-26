using CalculateShapeLibrary.Interfaces.Shapes;

namespace CalculateShapeLibrary.Interfaces.Services
{
    /// <summary>
    /// Сервис для вычисления характеристик треугольника
    /// </summary>
    public interface ITriangleService
    {
        double GetSquare(ITriangle triangle);

        bool IsRightTriangle(ITriangle triangle);
    }
}

using CalculateShapeLibrary.Interfaces.Shapes;

namespace CalculateShapeLibrary.Interfaces.Services
{
    /// <summary>
    /// Сервис для вычисления характеристик любой фигуры
    /// </summary>
    public interface IShapeService
    {
        double GetSquare(IShape shape);
    }
}

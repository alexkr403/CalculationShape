using CalculateShapeLibrary.Interfaces.Shapes;

namespace CalculateShapeLibrary.Interfaces.Services
{
    /// <summary>
    /// Сервис для вычисления характеристик круга
    /// </summary>
    public interface ICircleService
    {
        double GetSquare(ICircle circle);
    }
}

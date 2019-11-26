using CalculateShapeLibrary.Interfaces.Shapes;

namespace CalculateShapeLibrary.Consumer.Consumer
{
    /// <summary>
    /// Потребитель сервисов
    /// </summary>
    public interface IConsumerExample
    {
        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        double GetCircleSquare(ICircle circle);

        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        double GetTringleSquare(ITriangle triangle);

        /// <summary>
        /// Проверить, что треугольник прямоугольный
        /// </summary>
        bool IsRightTriangle(ITriangle triangle);

        /// <summary>
        /// Вычисление площади фигуры без знания типа фигуры
        /// </summary>
        double GetShapeSquare(IShape shape);
    }
}

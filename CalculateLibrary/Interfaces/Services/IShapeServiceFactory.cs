namespace CalculateShapeLibrary.Interfaces.Services
{
    /// <summary>
    /// Фабрика сервисов
    /// </summary>
    public interface IShapeServiceFactory
    {
        ICircleService CreateCircleService();

        ITriangleService CreateTriangleService();

        IShapeService CreateShapeService();
    }
}

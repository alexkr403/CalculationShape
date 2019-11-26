using System;
using CalculateShapeLibrary.Interfaces.Services;
using CalculateShapeLibrary.Interfaces.Shapes;

namespace CalculateShapeLibrary.Consumer.Consumer
{
    public class ConsumerExample : IConsumerExample
    {
        private readonly IShapeServiceFactory _shapeServiceFactory;

        public ConsumerExample(IShapeServiceFactory shapeServiceFactory)
        {
            _shapeServiceFactory = shapeServiceFactory ?? throw new ArgumentNullException(nameof(shapeServiceFactory));
        }

        public double GetCircleSquare(ICircle circle)
        {
            var circleService = _shapeServiceFactory.CreateCircleService();

            return
                circleService.GetSquare(circle);
        }

        public double GetTringleSquare(ITriangle triangle)
        {
            var circleService = _shapeServiceFactory.CreateTriangleService();

            return
                circleService.GetSquare(triangle);
        }

        public bool IsRightTriangle(ITriangle triangle)
        {
            var circleService = _shapeServiceFactory.CreateTriangleService();

            return
                circleService.IsRightTriangle(triangle);
        }

        public double GetShapeSquare(IShape shape)
        {
            var circleService = _shapeServiceFactory.CreateShapeService();

            return
                circleService.GetSquare(shape);
        }
    }
}

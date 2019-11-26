using CalculateShapeLibrary.Interfaces.Services;
using CalculateShapeLibrary.Interfaces.Shapes;

namespace CalculateShapeLibrary.Services
{

    public class ShapeService : IShapeService
    {
        public double GetSquare(IShape shape)
        {
            return
                shape.GetSquare();
        }
    }
}

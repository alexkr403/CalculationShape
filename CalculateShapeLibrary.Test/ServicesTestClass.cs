using CalculateShapeLibrary.Interfaces.Shapes;
using CalculateShapeLibrary.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CalculateShapeLibrary.Test
{
    [TestClass]
    public class ServicesTestClass
    {
        double radius = 100d;
        double expectCircleSquare = 31415.92654d;

        double a = 3d;
        double b = 4d;
        double c = 5d;
        double expectTriangleSquare = 6d;

        [TestMethod]
        public void CircleServiceTest()
        {
            var circle = new Mock<ICircle>();
            circle.SetupGet(z => z.Radius).Returns(radius);

            var circleService = new Mock<CircleService>();
            var circleSquare = circleService.Object.GetSquare(circle.Object);

            Assert.AreEqual(expectCircleSquare, circleSquare);
        }

        [TestMethod]
        public void TriangleServiceTest()
        {
            var triangle = new Mock<ITriangle>();
            triangle.SetupGet(z => z.A).Returns(a);
            triangle.SetupGet(z => z.B).Returns(b);
            triangle.SetupGet(z => z.C).Returns(c);

            var triangleService = new Mock<TriangleService>();
            var triangleSquare = triangleService.Object.GetSquare(triangle.Object);
            var isRightTriangle = triangleService.Object.IsRightTriangle(triangle.Object);

            Assert.AreEqual(expectTriangleSquare, triangleSquare);
            Assert.AreEqual(true, isRightTriangle);
        }

        [TestMethod]
        public void ShapeServiceTest()
        {
            var triangle = new Mock<ITriangle>();
            triangle.SetupGet(z => z.A).Returns(a);
            triangle.SetupGet(z => z.B).Returns(b);
            triangle.SetupGet(z => z.C).Returns(c);

            var circle = new Mock<ICircle>();
            circle.SetupGet(z => z.Radius).Returns(radius);

            var shapeService = new Mock<ShapeService>();

            var square = shapeService.Object.GetSquare(new NewShape());
            Assert.AreEqual(expectCircleSquare, square);
        }

        private class NewShape : IShape
        {
            public double GetSquare()
            {
                return
                    1 * 2 * 3 * 4 * 5;
            }
        }
    }
}

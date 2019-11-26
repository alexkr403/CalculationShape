using System;
using CalculateShapeLibrary.Consumer.CompositeRoot;
using CalculateShapeLibrary.Consumer.Consumer;
using CalculateShapeLibrary.Interfaces.Shapes;
using CalculateShapeLibrary.Shapes;
using Ninject;

namespace CalculateShapeLibrary.Consumer
{
    class Program
    {
        public static Workstation Root
        {
            get;
            private set;
        }

        static void Main(string[] args)
        {
            try
            {
                using (Root = new Workstation())
                {
                    Root.Init();

                    var consumer = Root.Get<IConsumerExample>();

                    var cirle = new Circle(134.07);
                    var triangle = new Triangle(
                        3000,
                        4000,
                        5000
                    );
                    
                    var cirleSquare = consumer.GetCircleSquare(cirle);
                    var triangleSquare1 = consumer.GetTringleSquare(triangle);
                    var isRightTriangle1 = consumer.IsRightTriangle(triangle);

                    var shape1 = consumer.GetShapeSquare(new NewShape());
                    
                    Console.WriteLine($"Площадь круга: {cirleSquare}");
                    Console.WriteLine($"Площадь треугольника: {triangleSquare1}");
                    Console.WriteLine($"Треугольник прямоугольный: {isRightTriangle1}");

                    Console.WriteLine($"Площадь фигуры 1: {shape1}");

                    Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private class NewShape: IShape
        {
            public double GetSquare()
            {
                return
                    1 * 2 * 3 * 4 * 5;
            }
        }
    }
}
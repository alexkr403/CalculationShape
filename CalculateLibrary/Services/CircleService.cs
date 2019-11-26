using System;
using CalculateShapeLibrary.Interfaces.Services;
using CalculateShapeLibrary.Interfaces.Shapes;

namespace CalculateShapeLibrary.Services
{
    public class CircleService : ICircleService
    {
        public double GetSquare(ICircle circle)
        {
            try
            {
                return
                    Math.Round(Math.PI * Math.Pow(circle.Radius, 2), 5);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //в боевом проекте здесь нужно разместить логирование

                return
                    -1;
            }
        }
    }
}

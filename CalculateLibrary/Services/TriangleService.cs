using System;
using CalculateShapeLibrary.Interfaces.Services;
using CalculateShapeLibrary.Interfaces.Shapes;

namespace CalculateShapeLibrary.Services
{
    public class TriangleService : ITriangleService
    {
        public double GetSquare(ITriangle triangle)
        {
            try
            {
                var p = (triangle.A + triangle.B + triangle.C) / 2d;
                var s = Math.Sqrt(p * (p - triangle.A) * (p - triangle.B) * (p - triangle.C));

                return
                    s;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //в боевом проекте здесь нужно разместить логирование

                return
                    -1;
            }
        }

        public bool IsRightTriangle(ITriangle triangle)
        {
            try
            {
                var aPow = Math.Pow(triangle.A, 2);
                var bPow = Math.Pow(triangle.B, 2);
                var cPow = Math.Pow(triangle.C, 2);

                if (Equals(aPow, bPow + cPow))
                {
                    return 
                        true;
                }

                if (Equals(bPow, aPow + cPow))
                {
                    return
                        true;
                }

                if (Equals(cPow, aPow + bPow))
                {
                    return
                        true;
                }

                return
                    false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //в боевом проекте здесь будет логирование

                return
                    false; //либо можно пробросить исключение, дело вкуса
            }
        }
    }
}

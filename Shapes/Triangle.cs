using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary.Shapes
{
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Стороны должны быть больше нуля.");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public bool IsRightAngled()
        {
            double hypotenuse = Math.Max(SideA, Math.Max(SideB, SideC));
            double otherSide1, otherSide2;

            if (hypotenuse == SideA)
            {
                otherSide1 = SideB;
                otherSide2 = SideC;
            }
            else if (hypotenuse == SideB)
            {
                otherSide1 = SideA;
                otherSide2 = SideC;
            }
            else
            {
                otherSide1 = SideA;
                otherSide2 = SideB;
            }

            //Проверка теоремы через сравнение с экспонентой
            return Math.Abs(Math.Pow(hypotenuse, 2) - (Math.Pow(otherSide1, 2) + Math.Pow(otherSide2, 2))) < 1e-10;
        }


    }
}

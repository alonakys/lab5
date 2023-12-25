using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp13
{
    class TRTriangle
    {
        protected double sideA;
        protected double sideB;
        protected double sideC;


        public double SideA
        {
            get { return sideA; }
            set
            {
                if (value > 0)
                {
                    sideA = value;
                }
                else
                {
                    throw new ArgumentException("Сторона трикутника повинна бути додатним числом.");
                }
            }
        }
        public double SideB
        {
            get { return sideB; }
            set
            {
                if (value > 0)
                {
                    sideB = value;
                }
                else
                {
                    throw new ArgumentException("Сторона трикутника повинна бути додатним числом.");
                }
            }
        }
        public double SideC
        {
            get { return sideC; }
            set
            {
                if (value > 0)
                {
                    sideC = value;
                }
                else
                {
                    throw new ArgumentException("Сторона трикутника повинна бути додатним числом.");
                }
            }
        }
        public TRTriangle() : this(3, 4, 5)
        {
        }
        public TRTriangle(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a)
            {
                SideA = a;
                SideB = b;
                SideC = c;
            }
            else
            {
                throw new Exception("Triangle does not exist");
            }
        }
        public TRTriangle(TRTriangle triangle)
        {
            SideA = triangle.sideA;
            SideB = triangle.sideB;
            SideC = triangle.sideC;
        }
        override public string ToString()
        {
            return $"Triangle with sides: a={sideA}, b={sideB}, c={sideC}";
        }
        public double CalcArea()
        {
            return 0.5 * sideA * sideB;
        }
        public double CalcPer()
        {
            sideC = Math.Sqrt(sideA * sideA + sideB * sideB);
            return sideA + sideB + sideC;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Side a: {sideA}\nSide b: {sideB}\nSide c: {sideC}\nTriangle's perimeter: {CalcPer()}\nTriangle's area: {CalcArea()}");
        }
        public static TRTriangle EnterInfo()
        {
            Console.WriteLine("Enter first side (а) as integer or decimal using comma separator:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second side (b) as integer or decimal using comma separator:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third side (c) as integer or decimal using comma separator:");
            double c = Convert.ToDouble(Console.ReadLine());
            return new TRTriangle(a, b,c);
        }
        public bool CompareTo(TRTriangle triangle)
        {
            double[] sidesOfFirstTriangle = new[] { sideA, sideB, sideC };
            Array.Sort(sidesOfFirstTriangle);
            double[] sidesOfSecondTriangle = new[] { triangle.SideA, triangle.SideB, triangle.SideC };
            Array.Sort(sidesOfSecondTriangle);
            bool areEqual = Enumerable.SequenceEqual(sidesOfFirstTriangle, sidesOfSecondTriangle);
            return areEqual;
        }
        public static TRTriangle operator *(double multi, TRTriangle triangle)
        {
            return new TRTriangle(multi * triangle.sideA, multi * triangle.sideB, multi*triangle.sideC);
        }
        public static TRTriangle operator *(TRTriangle triangle, double multi)
        {
            return new TRTriangle(multi * triangle.sideA, multi * triangle.sideB, multi*triangle.sideC);
        }
    }
}


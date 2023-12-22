using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class TRPiramid : TRTriangleF
    {
        protected double height;

        public double Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentException("Висота пiрамiди повинна бути додатнiм числом");
                }
            }
        }

        public TRPiramid() : this(3, 4, 5, 2)
        {
        }
        public TRPiramid(double a, double b, double c, double h) : base(a, b, c)
        {
            if (h > 0)
            {
                height = h;
            }
            else
            {
                throw new ArgumentException("Введено некоректно висоту");
            }
        }
        public TRPiramid(TRTriangle baseOf, double height) : this(baseOf.SideA, baseOf.SideB, baseOf.SideC, height)
        {
        }
        public TRPiramid(TRPiramid piram)
        {
            SideA = piram.SideA;
            SideB = piram.SideB;
            SideC = piram.SideC;
            Height = piram.Height;
        }
        public double CalcVolum()
        {
            return (1.0 / 3.0 * base.CalcArea() * height);
        }
        public override string ToString()
        {
            return $"Прямокутна трикутна пiрамiда зi сторонами {SideA}, {SideB} та висотою {height} має об'єм {CalcVolum()}";
        }
        public double PerimeterOfBase()
        {
            return base.CalcPer();
        }
        public new double CalcArea()
        {
            return 1.0 / 2.0 * PerimeterOfBase() * height + base.CalcArea();
        }
        public new void PrintInfo()
        {
            Console.WriteLine($"Sides of triangle base:\na={sideA}\nb={sideB}\nc={sideC}\nHeight: h={height}\nPerimeter of base: {this.PerimeterOfBase()}\nSurface area : {this.CalcArea()}\nVolume:{this.CalcVolum()}");
        }
        public static TRPiramid EnterInfo()
        {
            Console.WriteLine("Enter first side (а) of base as integer or decimal using comma separator:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second side (b) of base as integer or decimal using comma separator:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third side (c) of base as integer or decimal using comma separator:");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height of prizm as integer or decimal using comma separator:");
            double h = Convert.ToDouble(Console.ReadLine());
            return new TRPiramid(a, b, c, h);
        }
        public bool CompareTo(TRPiramid piram)
        {
            return base.CompareTo(piram) && this.height == piram.Height;
        }
        public static TRPiramid operator *(double multiplier, TRPiramid piram)
        {
            return new TRPiramid(multiplier * piram.SideA,  multiplier * piram.SideB,  multiplier * piram.SideC, multiplier * piram.height);
        }

        public static TRPiramid operator *(TRPiramid piram, int multiplier)
        {
            return new TRPiramid( multiplier * piram.sideA,  multiplier * piram.sideB,  multiplier * piram.sideC, multiplier * piram.height);
        }
    }
}

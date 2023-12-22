using System;
using System.Collections.Generic;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            TRTriangle first = new TRTriangle(3, 4, 5);
            HashSet<TRTriangle> triangles = new HashSet<TRTriangle>() { first };
            TRTriangle second = new TRTriangle(3, 4, 5);
            Console.WriteLine(triangles.Contains(second));

            TRTriangleF firstF = new TRTriangleF(3, 4, 5);
            HashSet<TRTriangleF> trianglesF = new HashSet<TRTriangleF>() { firstF };
            TRTriangleF secondF = new TRTriangleF(3, 4, 5);
            Console.WriteLine(trianglesF.Contains(secondF));


            TRPiramid firstP = new TRPiramid(3, 4, 5, 1);
            TRPiramid secondP = new TRPiramid(3, 4, 5, 2);
            TRPiramid thirdP = new TRPiramid(3, 4, 5, 3);
            TRPiramid fourthP = new TRPiramid(3, 4, 5, 4);
            TRPiramid fifthP = new TRPiramid(3, 4, 5, 5);
            HashSet<TRPiramid> prizms = new HashSet<TRPiramid>() { firstP, secondP, thirdP, fourthP, fifthP };
            Console.WriteLine(prizms.Count);

            TRPiramidF firstPF = new TRPiramidF(3, 4, 5, 1);
            TRPiramidF secondPF = new TRPiramidF(3, 4, 5, 2);
            TRPiramidF thirdPF = new TRPiramidF(3, 4, 5, 3);
            TRPiramidF fourthPF = new TRPiramidF(3, 4, 5, 4);
            TRPiramidF fifthPF = new TRPiramidF(3, 4, 5, 5);
            HashSet<TRPiramidF> prizmsF = new HashSet<TRPiramidF>() { firstPF, secondPF, thirdPF, fourthPF, fifthPF };
            Console.WriteLine(prizmsF.Count);
        }
    }
}

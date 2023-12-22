using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class TRTriangleF:TRTriangle
    {
        public TRTriangleF():base(3,4,5)
        {
        }
        public TRTriangleF(double a, double b) : base(a, b)
        {
        }
        public TRTriangleF(double a, double b, double c) : base(a, b, c)
        {
        }
        public override bool Equals(object? obj)
        {
            return obj is TRTriangleF && this.CompareTo((TRTriangle)obj);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(sideA + sideB + sideC);
        }
    }
}

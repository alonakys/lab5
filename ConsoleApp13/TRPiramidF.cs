using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class TRPiramidF:TRPiramid
    {
        public TRPiramidF() : base()
        {
        }
        public TRPiramidF(double a, double b, double c, double h) : base(a, b, c, h)
        {
        }
        public override bool Equals(object? obj)
        {
            return obj is TRPiramidF f && base.Equals(obj) && Height == f.Height;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), height);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareIt
{
    public class Triangle : Shape
    {
        public Triangle() 
            : base(3) { }

        public Triangle(double a, double b, double c) 
            : this()
        {
            A = a;
            B = b;
            C = c;
        }

        public double A
        {
            get => Dimensions[0];
            set => Dimensions[0] = value;
        }
        public double B
        {
            get => Dimensions[1];
            set => Dimensions[1] = value;
        }
        public double C
        {
            get => Dimensions[2];
            set => Dimensions[2] = value;
        }

        public override double GetSquare()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRectangled
        {
            get
            {
                var hypo = Dimensions.Max();
                return hypo * hypo == A * A + B * B + C * C - hypo * hypo;
            }
        }
    }
}

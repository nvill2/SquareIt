using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareIt
{
    public class Rectangle : Shape
    {
        public Rectangle() : base(2) { }
        public Rectangle(double a, double b) :this()
        {
            A = a;
            B = b;
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

        public override double GetSquare()
        {
            return A * B;
        }
    }
}

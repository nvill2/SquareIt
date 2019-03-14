using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareIt
{
    public class Circle : Shape
    {
        public Circle()
            : base(1)
        {
        }
        public Circle(double r) 
            : this()
        {
            R = r;
        }
        public double R
        {
            get => Dimensions[0];
            set => Dimensions[0] = value;
        }

        public override double GetSquare()
        {
            return Math.PI * R * R;
        }
    }
}

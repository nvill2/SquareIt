using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareIt
{
    public class Shape
    {        
        //так удобно любое количество сторон
        protected Shape(int count)
        {
            Dimensions = new double[count];
        }
        public Shape(params double[] dimensions)
        {
            Dimensions = dimensions;
        }

        public virtual double GetSquare()
        {
            //универсальная площадь
            switch (Dimensions.Count)
            {
                case 1:
                    return new Circle(Dimensions[0]).GetSquare();                    
                case 2:
                    return new Rectangle(Dimensions[0], Dimensions[1]).GetSquare();
                case 3:
                    return new Triangle(Dimensions[0], Dimensions[1], Dimensions[2]).GetSquare();
                default:
                    return 0;
            }
        }
        public IList<double> Dimensions { get; set; }
    }
}

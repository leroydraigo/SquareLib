using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLib
{
    public class Triangle : IFigure
    {
        public double a,b,c;

        public Triangle() { }

        public Triangle(double a, double b, double c) 
        { 
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Square()
        {
            double p = (a + b + c)/2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        


        public bool isRightAngled() 
        {
            if (a > b)
            {
                if ((a > c) && (a * a == ((b * b) + (c * c))))
                    return true;
            }
            else
            {
                if ((b > c) && (b * b == ((a * a) + (c * c))))
                    return true;                
            }
            if (c * c == ((a * a) + (b * b)))
                return true;
            return false; 
        }
    }
}

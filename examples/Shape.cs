using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples
{
     interface Shape
    {
        double area(double l, double b);

    }
   public class RactangleDemo:Shape
    {
        public double area(double l,double b)
        {
            return l * b;
        }
    }

}

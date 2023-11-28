using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace examples
{
    internal class Circle
    {
        private int radius;

        public void setRaidious(int r)
        {
            radius = r;
        }
        /*
        public void calculateArea()
        {
            double area= Math.PI*Math.Pow(radius ,2);
            Console.WriteLine("Area of circle:"+area);
            
        }
        publicvoid calCircumference()
        {
            double c= 2*Math.PI*radius;
           Console.WriteLine("cercumfarince is:"+c);
        }
        */
        // with return

        public double calculateArea()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
        public double calCircumference()
        {
            double c = 2 * Math.PI * radius;
            return c;
        }


    }
}

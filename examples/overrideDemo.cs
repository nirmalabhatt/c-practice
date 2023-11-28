using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace examples
{
     class overrideDemo
    {
        private int rad;
        public overrideDemo(int rad)
        {
            this.rad = rad;
        }
        public double getArea()
        {
            double area = Math.PI * rad * rad;
            return area;
        }
        public double getCircum()
        {
            double circ = 2 * Math.PI * rad;
            return circ;
        }


    }
     class Cylinder:overrideDemo
    {
        private int height;

        public Cylinder(int rad,int height) : base(rad)
        {
       

        }

        public double getArea()
    {
        double area = 2 * base.getArea() +getCircum()*height;
        return area;
    }
}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2z
{
    internal class Cylinder
    {
        private int radius;
        private int height;

        public void setRadius(int r)
        {
            radius = r;
        }

        public void setHeight(int h)
        {
            height = h;
        }

        public double calculateVolume()
        {
            double vol = Math.PI * Math.Pow(radius, 2) * height;
            return vol;
        }
    }
}

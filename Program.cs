using System;
namespace Abstract
{
    internal class Program
    {
        public abstract class Shape
        {
            public abstract double Area();
            public abstract double Perimeter();
        }
            class Rectangle : Shape
         {
            double length;
            double width;
            public Rectangle(double l, double w)
            {
                length = l;
                width = w;
            }
            public override double Area()
            {
                return length * width;
            }
            public override double Perimeter()
            {
                return 2 * (length + width);
            }
        }
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 7);

            double area = r.Area();
            double perimeter = r.Perimeter();
            Console.WriteLine("Area of Rectangle: " + area);
            Console.WriteLine("Perimeter of Rectangle: " + perimeter);
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2z
{
    internal class UsesCylinder
    {
        static void Main(string[] args)
        {
            Cylinder obj = new Cylinder();
            Console.WriteLine("Enter the value of radius: ");
            int rad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of height");
            int hgt = Convert.ToInt32(Console.ReadLine());  
            obj.setRadius(rad);
            obj.setHeight(hgt);
            double vol = obj.calculateVolume();
            Console.WriteLine("The volume of cylinder is "+vol);

        }
    }
}

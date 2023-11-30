using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVar
{
    public class operatorExample
    {
        public int a = 10;
        public void Demoarithemeticop()
        {
           int a = 10;
            int b = 3;
            float c = (float)a / (float) b;
            int d = a % b;
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
        public void DemoRelationalop()
        {
            int a = 5;
            int b = 3;
            int c = 12;
            Console.WriteLine(a==b);
            Console.WriteLine(a>b);
            Console.WriteLine(a<=b);
            Console.WriteLine(a!=b);
            Console.WriteLine(a>b && a>c);
            Console.WriteLine(!(a>b ||a>c));
           
        }
    }
}

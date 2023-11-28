using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples
{
    internal class Overloading
    {
        public static int add(int a,int b)
        {
            return a + b;
        }
        public static int add(int a, int b,int c)
        {
            return a + b+c;
        }

    }
   
}

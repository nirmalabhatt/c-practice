using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] e = { 45,74,96,10,25,80,40,90,17,35,85 };
            var b=from i in e where i>=40 && i<=60 orderby i descending select i;
            foreach(var i in b)
            {
                Console.WriteLine(i);
            }
        }
    }
}

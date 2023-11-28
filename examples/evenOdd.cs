using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples
{
    internal class evenOdd
    {
        public void evenoddnumber()
        {
            Console.WriteLine("enter a number");
            int num=Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("number is even");
            else
                Console.WriteLine("number is odd");
        }
    }
}

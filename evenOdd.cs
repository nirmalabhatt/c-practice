using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples1
{
    internal class evenOdd
    {
        public void evenodd()
        {
            Console.WriteLine("Enter the number for check ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("even number");
            }
            else
                Console.WriteLine("number is odd");
        }
    }
}

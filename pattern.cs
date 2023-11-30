using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples1
{
    internal class pattern
    {
        public void patternPrint()
        {
            Console.WriteLine("enter a number");
            int n= Convert.ToInt32(Console.ReadLine());
            int x, y;
            for (x = 1; x <= n; x++)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
    }


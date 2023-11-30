using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples1
{
    internal class PrimeNumber
    {
        bool flag;
        public void primeNumber()
        {
         
            Console.WriteLine("enter a number");
            int num=Convert.ToInt32(Console.ReadLine());
            for(int i = 2; i < num; i++)
            {
                if (num % i == 0) ;
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("not a prrime number");
            }
            else
                Console.WriteLine("prime number");
        }
    }
}

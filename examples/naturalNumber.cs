using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples
{
    internal class naturalNumber
    {
        public void naturalNumbers()
        {
            int j, sum = 0;
            double avj;
            
            
            Console.WriteLine("The first 10 natural number are :\n");
            for (j = 1; j <= 10; j++)
            {
                sum = sum + j;
                Console.WriteLine("{0} ", j);
            
            }
            avj = sum / 10;
            Console.WriteLine("The Sum of natural numbers are: {0}", sum);
            Console.WriteLine("the avarage is:"+ avj);
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples1
{
    internal class factorialExample
    {
        public void factorial()
        {
            int i, fact = 1;
            Console.WriteLine("enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of " + number + " is: " + fact);
        }
    }
}

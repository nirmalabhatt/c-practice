using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples1
{
    internal class SumofDigit
    {
        public void sum()
        {
            int sum=0;
            int m=0;
            Console.WriteLine("Enter the number of elements: ");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                m = number % 10;
                sum = sum+m;
                number = number / 10;

            }
            Console.Write("Sum is= " + sum);

        }
    }
}

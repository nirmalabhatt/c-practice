using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinoLAndamda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 5, 8, 11, 15, 18, 20 };

            // Using LINQ
            var result = from num in array where num % 2 == 0 select num;

            Console.WriteLine("Using LINQ:");
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }

            // Using Lambda expression
            var evenNumbers = array.Where(x => x % 2 == 0);

            Console.WriteLine("\nUsing Lambda expression:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
    
}

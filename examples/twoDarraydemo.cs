using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples
{
    internal class twoDarraydemo
    {


        public void twoDimensionalarray()
        {
            int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int sum = 0;

            Console.WriteLine("2D Array elements are:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                    sum += arr[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sum of 2D array elements: " + sum);
            Console.ReadLine();


        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples1
{
    internal class ArrayExample
    {
        public void ArrayExamples()
        {
            string[] array = new string[6];
            array[0] = "nirmala";
            array[1] = "sarita";
            array[2] = "bhuwan";
            array[3] = "deepak";
            array[4] = "sudha";
            array[5] = "nisha";
            Console.WriteLine();
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }



        }
    }
}

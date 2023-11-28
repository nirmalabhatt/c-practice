using System;
namespace examples
{
    internal class ArrayDmo
    {
        public void arrayDemo()
        {
            int [] arr = {1,2,3,4,5,6,7,8,9,10};
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine("Maximum number is "+max);
            Console.WriteLine("Minimum number is "+min); 
        }
    }
   
}

            

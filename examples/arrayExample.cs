using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace examples
{
    /* program to accept an integer from user & store all the prime number
     * up  to that number in array which is dynamically sized
     * finally print the element of the array:*/
    internal class arrayExample
    {
      
       
        int i, j,k; 

        public void arrayPrime()
        {
            
            Console.WriteLine("Enter a Number:");
            int a= Convert.ToInt32(Console.ReadLine());
            int[] arr;
            arr = new int[a];
            Console.WriteLine("The elements of array");
            int b = 1;
            for (i=0;i<arr.Length;i++)
            {
              
                arr[i] = b;
                b = b + 1;
                Console.WriteLine(arr[i]);
                
            }
            Console.WriteLine("The prime numbers are ");
            for( i=0;i<arr.Length;i++)
            {
                   k = arr[i];
                int count = 0;
                for (j=1;j<=k;j++)
                {
                    
                    if(k%j==0)
                    {
                       count++;
                    }
                }
                if(count == 2)
                {
                    Console.Write(arr[i]+" ");                
                }

            }
            
            
        }
    }
}

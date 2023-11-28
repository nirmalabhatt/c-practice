using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples
{
    internal class twoDarray
    {
        
        public void twodArray()
        {
            int[][] arr = new int[2][];
            arr[0]=new int[2];
            arr[1]=new int[2];  
            Console.WriteLine("Enter numbers");
           
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j]=Convert.ToInt32(Console.ReadLine());
                }
                
            }
            //int sum=0;
            //double avj;
            Console.WriteLine("The array elements are ");
            for (int i = 0; i < arr.Length; i++)
            {
                  int sum = 0;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+" ");
                    sum=sum+arr[i][j];
                   
                }
                Console.WriteLine();
                Console.WriteLine("The sum of"+(i+1)+"row is:"+sum);
               
            }
           // Console.WriteLine("The sum is " + sum);


           // avj = sum / (arr.Length * arr[0].Length);
           // Console.WriteLine(" the avarage is:"+avj);

        }
    }
}

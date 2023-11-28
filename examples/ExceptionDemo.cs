using System;
namespace examples
{
    internal class ExceptionDemo
    {
        public void ExceptionExample()
        {
            int[] array = new int[5];
            try
            {
                int a = 10, b = 0;
                int c = a / b;
            }catch (DivideByZeroException e)
            {
                 
                Console.WriteLine("not possible to divide by zero :\n {0}", e);
            }
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("please input number in range :\n {0}", e);
            }
        }
    }
   
}





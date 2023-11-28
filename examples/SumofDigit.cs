using System;
namespace examples
{
 internal class SumofDigit
    {
        int sum=0,x;
        public void sumofDigits()
        {
            Console.WriteLine("Enter a digit:");
            int n= Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                x = n % 10;
                sum= sum+ x;
                n = n / 10;
            }
            Console.WriteLine("The Sum of Entered digit is:"+sum);
        }
    }
  
}  

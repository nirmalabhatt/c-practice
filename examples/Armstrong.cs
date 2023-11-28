using System;
namespace examples
{
    internal class Armstrong
    {
        public void armstrongNumber()
        {
            int rem,t,s=0;
            Console.WriteLine("Enter the number:");
            int n= Convert.ToInt32(Console.ReadLine());
            t = n;
            while (n!= 0)
            {
                rem = n % 10;
                s = (int)(s + Math.Pow(rem, 3));
                n = n / 10;
            }
            if (s == t)
                Console.WriteLine("The number {0} is Armstrong Number:", t);
            else
                Console.WriteLine("The number{0} is  not Armstrong Number:", t);
        }
    }
   

}
            
            

            
            





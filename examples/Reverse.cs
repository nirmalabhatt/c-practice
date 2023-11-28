using System;
namespace examples
{
    internal class Reverse
    {
        public void reverseNumber()
        {
            int reverse = 0, rem;
            Console.WriteLine("Enter a digit:");
            int n = Convert.ToInt32(Console.ReadLine());
            while(n !=0)
            {
                rem = n % 10;
                reverse= reverse*10+rem;
                n/=10;
            }
            Console.WriteLine("Reverse Numner::"+reverse);

        }
    }
   
}



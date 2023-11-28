using System;
namespace examples
{
    internal class Prime
    {
        int i;

        public void primeNumber()
        {
            Console.WriteLine("Enter a digit:");
            int n = Convert.ToInt32(Console.ReadLine());
            for(i = 2; i <=n-1; i++)
            {
                if(n%i== 0)
                    break;
            }
            if(n==i)

                Console.WriteLine("The given Number is Prime Number:");
            
            else
                Console.WriteLine("The given Number is not Prime Number:");
        }
    }
   
}



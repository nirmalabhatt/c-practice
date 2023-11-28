using System;
namespace examples
{
    internal class PalindroneDemo
    {
        int a, p = 0, r;
        public void palindromeNumber()

        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            a= num;
            while(num!= 0)
            {
                r = num % 10;
                p = p*10+r;
                num= num/10;
            }
            if (a == p)
                Console.WriteLine("{0} is palindrone number:", a);
            else
                Console.WriteLine("{0} is not a palindrone number:", a);
        }
    }
  

}
           



           
           

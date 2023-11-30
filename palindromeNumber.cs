using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples1
{
    internal class palindromeNumber
    {
        //program to check if a number is a palandrome number or not:
        int rev,rem;
        int ans =0;
        public void palindrome()
        {
            Console.WriteLine("Enter the number for check ");
            int number = Convert.ToInt32(Console.ReadLine());
            rev = number;
            while (rev != 0)
            {
                rem = rev % 10;
                ans = ans * 10 + rem;
                rev = rev / 10;
            }
            if(ans == number)
            {
                Console.WriteLine("palindrone number");
            }
            else
            {
                Console.WriteLine(" not a palindrone number");
            }

        }
    }
}

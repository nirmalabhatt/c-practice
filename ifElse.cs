using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//WAp to take 2 values from user and print if num is in between 0 to10 print valid num else invilid:
namespace Example_String
{
    internal class ifElse
    {
        public void ifElsecase()
        {
            Console.WriteLine("enter the first numner ");
            int num=Convert.ToInt32(Console.ReadLine());
           // int num  =int.Parse(Console.ReadLine());
            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("valid number");
            }
            else
                Console.WriteLine("invilid number");

        }
    }
}

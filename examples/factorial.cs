using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace examples
{
    internal class factorial
    {
        public void factorialExmple()
        {
            Console.WriteLine("enter a number");
            int num= Convert.ToInt32(Console.ReadLine());
            int i = 1;
            if(num>1)
            {
                do
                {
                    i=i*num;
                    num--;
                }
                while(num>1);
            }
            Console.WriteLine("factorial is"+i);
        }
    }
    

}

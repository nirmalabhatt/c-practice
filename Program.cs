using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligateDemo
{
    delegate int Number(int n);
    internal class Program
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num+=p;
            return num;
        }
        public static int MulNum(int q)
        {
            num *= q;
            return num;
        } 
        public static int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
          
            Number n1 = new Number(AddNum);
            Number n2 = new Number(MulNum);
            n1(25);
            Console.WriteLine("The value of Addition is:{0}",getNum());
            n2(5);
            Console.WriteLine("The value of Multiplication is:{0}", getNum());
             /*
            Number n;
            Number n1 = new Number(AddNum);
            Number n2 = new Number(MulNum);
            n = n1;
            n += n2;
            n(5);
            Console.WriteLine(" value of Number is :{0}",getNum());
             */
        }
    }
}

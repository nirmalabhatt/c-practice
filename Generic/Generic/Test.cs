using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Test<T>
    {
        public T val;

        // generic constructor 
        public Test(T t)
        {
            val = t;
        }

        // generic method 
        public T GetVal()
        {
            return val;
        }
    }
    public class Show
    {


        static void Main(string[] args)
        {
            Test<int> ob = new Test<int>(15);

            // instance of String type 
            Test<string> ob1 = new Test<string>("Nirmala Bhatt");

            Console.WriteLine(ob.GetVal());
            Console.WriteLine(ob1.GetVal());
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiLevelInheritance
{
    
    public class A
    {
        public void MethodA()
        {
            Console.WriteLine("Method A from Class A");
        }
    }

    public class B : A
    {
        public void MethodB()
        {
            Console.WriteLine("Method B from Class B");
        }
    }

    public class C : B
    {
        public void MethodC()
        {
            Console.WriteLine("Method C from Class C");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.MethodA();
            b.MethodB();
            b.MethodC();
        }
    }
}

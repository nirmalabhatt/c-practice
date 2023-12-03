using System;
namespace RelatoonalOperatorOverloadimg
{
    internal class Program
    {
        int x;
        int y;

        //class constructors
        public Program() { }
        public Program(int a, int b)
        {
            x = a;
            y = b;
        }
        //method for overloading <
        public static bool operator <(Program p1, Program p2)
        {
            Double d1 = Math.Sqrt(p1.x * p1.x + p1.y * p1.y);
            Double d2 = Math.Sqrt(p2.x * p2.x + p2.y * p2.y);
            return d1 < d2 ? true : false;
        }
        //method for overloading >
        public static bool operator >(Program p1, Program p2)
        {
            Double d1 = Math.Sqrt(p1.x * p1.x + p1.y * p1.y);
            Double d2 = Math.Sqrt(p2.x * p2.x + p2.y * p2.y);
            return d1 > d2 ? true : false;
        }


        static void Main(string[] args)
        {
            Program p1 = new Program(10, 15);
            Program p2 = new Program(5, 25);
            Program p3 = new Program(12, 14);

            Console.WriteLine("(p1 > p2) returns: {0}", (p1 > p2));
            Console.WriteLine("(p1 < p3) returns: {0}", (p1 < p3));
        }
    }
}

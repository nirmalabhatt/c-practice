/*
using System;
using examples;
namespace examples
{
    internal class operatorO
    {
        private int x;
        private int y;
        public operatorO()
        {

        }
        public operatorO(int i, int j)
        {
            x = i;
            y = j;
        }
        public void showXy()
        {
            Console.WriteLine("{0} {1}", x, y);
        }
        public static operatorO operator +(operatorO c1, operatorO c2)
        {
            operatorO temp = new operatorO();
            temp.x = c1.x + c2.x;
            temp.y = c1.y + c2.y;
            return temp;
        }
    }
    }
class MyClient
{
    public static void Main()
    {
        operatorO c1 = new operatorO(10, 20);
        c1.showXy(); // displays 10 & 20  
        operatorO c2 = new operatorO(20, 30);
        c2.showXy(); // displays 20 & 30  
        operatorO c3 = new operatorO();
        c3 = c1 + c2;
        c3.showXy(); // dislplays 30 & 50  
    }
}*/





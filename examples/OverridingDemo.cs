using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples
{
    internal class OverridingDemo
    {
        public class Animal
        {
            public virtual void Eat()
            {
                Console.WriteLine("Eating...");
            }
        }

        public class Bird : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("The Bird is Eating...");
            }
        }
    }
    //internal class mainClass
   // {
   //     //static void Main(string[] args)
   //     {
   //         Reverse reverse = new Reverse();
   //         reverse.reverseNumber();
   //     }
   // }
}

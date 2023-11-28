using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples
{
    internal class Calculator
    {
        public int number = 0;
        public Calculator() { }
        public Calculator(int n)
        {
           number = n;
        }
        /*
        public static Calculator operator +(Calculator C1,Calculator C2)
        {
            Calculator Calc3 = new Calculator(0);
            Calc3.number = C1.number + C2.number;
            return Calc3;
        }
        */
        public static Calculator operator -(Calculator c1, Calculator c2)
        {
            Calculator Calc4 = new Calculator(0);
            Calc4.number = c1.number - c2.number;
            return Calc4;
        }

            public void display()
        {
            Console.WriteLine("{0}", number);
        }
       
        
    }
    
}

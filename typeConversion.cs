using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVar
{
    internal class typeConversion
    {
        public void implictconversion()
        {
            byte b = 11;
            int i = b;
            Console.WriteLine(i);

        }
        public void implictconversion2()
        {
            int i= 1;
            byte b = (byte) i;

        }
        public void noncompt()
        {
            
               
            try
            {
                String s = "Ram";
                int i = Convert.ToInt32(s);
                Console.WriteLine(i);
            }
            catch (Exception)
            {

                Console.WriteLine("Please input numbers only");
            }
            
            

        }
       public void noncompt2()
        {
            
            try
            {
                String str = "manish";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {

                Console.WriteLine("Please input either true or false only");
            }
        }
        public void divisionByzero()
        {
            try
            {
                int a = 1;
                int b = 0;
                int c;
                c = a / b;
                Console.WriteLine(c);

            }
            catch (Exception 
            )
            {

                Console.WriteLine("please insert valid input");
                
            }
            
        }
    }
    
}

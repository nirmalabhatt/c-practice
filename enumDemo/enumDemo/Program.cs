using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine(days.sunday);
            Console.WriteLine(days.wednesday);
            Console.WriteLine(days.thursday);
            Console.WriteLine(days.friday);
            Console.WriteLine(days.saturday);
            Console.WriteLine(days.monday);
            Console.WriteLine((int)days.thursday+(int)days.friday);
            */
           foreach(string name in Enum.GetNames(typeof(days)))//Returns the value of enum:
            //foreach(int name in Enum.GetValues(typeof(days)))//get the values 1,2,3:
            {
                Console.WriteLine(name);
            }
            

        }

    }
    enum days 
     {
        sunday,
        monday , 
        tuesday, 
        wednesday,
        thursday, 
        friday,
        saturday

    }
}

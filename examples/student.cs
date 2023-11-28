using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples
{
    //program paramererized constructor:
    public class student
    {
        string name;
        int age;
        public student(string Name, int Age)
        {
            name = Name;
            age = Age;
        }
        public void display()
        {
            Console.WriteLine(name +"," + age);
        }
    }
    

}


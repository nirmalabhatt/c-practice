using System;
using DemoNonPrimitive.Demo;

namespace DemoNonPrimitive
{
    public class Class1
    {
        public String name;
        public int age;

        public void Display()
        {
            Console.WriteLine("Name is "+name +" Age is "+age);
        }
        public static void Main(String[] args)
        {
            Class1 c = new Class1();
            c.name = "John";
            c.age = 25;
            c.Display();
            Class2 c2 = new Class2();
            int y= c2.Add(5, 3);
            Console.WriteLine(y);
            //FolderClass.DemoFolder();
            
        }
    }
}

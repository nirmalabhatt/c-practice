using System;
namespace examples
{
    public interface Interface1
    {
        void draw();
    }
    public class Ractangle : Interface1
    {
        public void draw()
        {
            Console.WriteLine("drawing ractangle");
        }
    }
    public class circle:Interface1
    {
        public void draw()
        {
            Console.WriteLine("drawing circle");
        }
    }
    
}

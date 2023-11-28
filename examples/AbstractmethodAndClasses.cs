using System;
namespace examples
{
    abstract class AbstractmethodAndClasses
    {
        public int add(int i, int j)
        {
            return i + j;
        }
        public abstract int mul(int i, int j);
    }
    class abs2 : AbstractmethodAndClasses
    {
        public override int mul(int i, int j)
        {
            return i * j;
        }
    }
    class abs3 : AbstractmethodAndClasses
    {
        public override int mul(int i, int j)
        {
            return i - j;
        }
    }
    class abs4 : abs2

    {
        public override int mul(int i, int j)
        {
            return i + j;
        }
    }
    
}







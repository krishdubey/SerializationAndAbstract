using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSerializableAbstra
{
    abstract class AbstractClass2
    {
        public void sum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public abstract void mul(int x, int y);
        public abstract void div(int x, int y);
    }

    class Test2 : AbstractClass2
    {
        public override void div(int x, int y)
        {
           Console.WriteLine(x/y);
        }

        public override void mul(int x, int y)
        {
            Console.WriteLine(x*y);
        }
        static void Main(string[] args)
        {
            Test2 t2 = new Test2();
            t2.sum(10, 20);
            t2.sub(20, 10);
            t2.mul(10, 5);
            t2.div(20, 10);
            Console.ReadLine();
        }
    }
}

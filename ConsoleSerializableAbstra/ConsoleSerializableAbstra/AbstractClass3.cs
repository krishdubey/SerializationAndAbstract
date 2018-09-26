using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSerializableAbstra
{
    abstract class AbstractClass3
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

    class Test3 : AbstractClass3
    {
        public override void div(int x, int y)
        {
            Console.WriteLine(x / y);
        }

        public override void mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        static void Main(string[] args)
        {
            Test3 t3 = new Test3();

           // AbstractClass3 c1 = new AbstractClass3(); // we can not create object of abstract class.

            AbstractClass3 c1 = t3; // we can create refrence of abstract class. 

            c1.sum(10, 20);
            c1.sub(20, 10);
            c1.mul(10, 5);
            c1.div(20, 10);
            Console.ReadLine();
        }
    }
}

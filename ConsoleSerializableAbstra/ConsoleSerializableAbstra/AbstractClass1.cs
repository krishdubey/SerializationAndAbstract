using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSerializableAbstra
{
    abstract class AbstractClass1
    {
                   
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        public void Sum()
        {
            Console.WriteLine("sum is" + a + b);
        }
    }

    class Test : AbstractClass1
    {
        public void showable()
        {
            Console.WriteLine("Hello to everyone");
        }
        static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.Sum();
            t1.showable();

            Console.ReadLine();
        }
        
    }

}

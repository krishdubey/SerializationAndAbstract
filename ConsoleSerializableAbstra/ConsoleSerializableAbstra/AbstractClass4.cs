using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSerializableAbstra
{
    abstract class BaseClass
    {
        protected int _x = 100;
        protected int _y = 150;
        public abstract void AbstractMethod();   // Abstract method
        public abstract int X { get; }  // Abstract attribute
        public abstract int Y { get; }  // Abstract attribute
    }

    class DerivedClass : BaseClass
    {
        public override void AbstractMethod()
        {
            _x++;
            _y++;
        }

        public override int X   // overriding property
        {
            get
            {
                return _x + 10;
            }
        }

        public override int Y   // overriding property
        {
            get
            {
                return _y + 10;
            }
        }

        static void Main()
        {
            DerivedClass o = new DerivedClass();
            //    o.AbstractMethod();
           // o.AbstractMethod();
            Console.WriteLine("x = {0}, y = {1}", o.X, o.Y);
            Console.ReadLine();
        }
    }
}

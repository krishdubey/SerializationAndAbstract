using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSerializableAbstra
{
  public abstract class Figure
    {
        public double Width, Height, Radius;
        public const float Pi = 3.14f;

        public abstract double GetArea();
    }

   public class Rectangle : Figure
    {
        public Rectangle(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

   public class Circle : Figure
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public override double GetArea()
        {
            return Pi * Radius * Radius;
        }
    }

   public class Cone : Figure
    {
      public Cone(double Radius, double Height)
        {
            this.Radius = Radius;
            this.Height = Height;
        }

        public override double GetArea()
        {
            return Pi * Radius * (Radius + Math.Sqrt(Height * Height + Radius*Radius));
        }
    }

    class TestFigure
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(5.5, 6.5);
            Circle c = new Circle(3.0);
            Cone c1 = new Cone(1.5, 2.5);

            Console.WriteLine("Area of Rectangle:" + r.GetArea());
            Console.WriteLine("Area of Circle:" + c.GetArea());
            Console.WriteLine("Area Of Cone:" + c1.GetArea());

            Console.ReadLine();
        }
    }
}

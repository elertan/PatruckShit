
using System;
namespace ConsoleApplication1
{

    public class Shape
    {
        public static double PI = 3.14;
    }

    public class Circle : Shape
    {
        public double Straal;

        public Circle(double Straal)
        {
            this.Straal = Straal;
        }

        public double GetArea()
        {
            return this.Straal * this.Straal * Circle.PI;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(2.5);
            Circle circle2 = new Circle(2);

            Console.WriteLine(circle1.GetArea());
            Console.WriteLine(circle2.GetArea());

            Console.ReadKey();

        }
    }
}

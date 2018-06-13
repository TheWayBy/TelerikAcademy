using System;

namespace Trapezoids
{
    public class Program
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area  = ((a+b)*h)/ 2;
            Console.WriteLine("Area: {0}", area);
            Console.ReadKey();
        }
    }
}

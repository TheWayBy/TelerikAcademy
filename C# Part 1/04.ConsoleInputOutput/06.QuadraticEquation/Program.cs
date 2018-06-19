using System;

namespace QuadraticEquation
{
    public class Program
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            double D;
            double x1;
            double x2;

            D = Math.Pow(b, 2) - 4 * a * c;

            if (D == 0)
            {
                x1 = -(b / (2 * a));
                Console.WriteLine("The quadratic equation has one real root: {0}", x1);
            }
            else if (D > 0)
            {
                x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                Console.WriteLine("The quadratic equation has two real roots: x1 = {0} and x2 = {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("no real roots");
            }


            Console.ReadKey();
        }
    }
}

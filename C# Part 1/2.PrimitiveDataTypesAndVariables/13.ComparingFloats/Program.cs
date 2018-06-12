using System;

namespace ComparingFloats
{
    public class Program
    {
        public static void Main()
        {
            double a;
            double b;
            double eps = 0.000001;
            a = double.Parse(Console.ReadLine()); 
            b = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Abs(a - b) < eps);
            Console.ReadKey();
          
        }
    }
}

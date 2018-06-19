using System;

namespace CirclePerimeterAndArea
{
    public class Program
    {
        public static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("The area is:{0:F2}", Math.PI * Math.Pow(r, 2));
            Console.WriteLine("The perimeter is: {0:F2}", 2*Math.PI*r);
            Console.ReadKey();
        }
    }
}

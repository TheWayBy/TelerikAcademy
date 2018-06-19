using System;

namespace NumberComparer
{
   public class Program
    {
        public static void Main()
        {
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            float greather = Math.Max(num1, num2);
            Console.WriteLine("The hreather number is: {0}", greather);
            Console.ReadKey();
        }
    }
}

using System;

namespace SumOfThreeNumbers
{
    public class Program
    {
        public static void Main()
        {
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            float num3 = float.Parse(Console.ReadLine());
            Console.WriteLine(num1+num2+num3);
            Console.ReadKey();
        }
    }
}

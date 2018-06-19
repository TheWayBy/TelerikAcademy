using System;

namespace FormattingNumbers
{
    public class Program
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            int binnaryA = int.Parse(Convert.ToString(a, 2));
            Console.Write("{0,-10:X}|{1,10:D10}|{2,10:F2}|{3, 10:F3}", a, binnaryA, b, c);
            Console.ReadKey();

        }
    }
}

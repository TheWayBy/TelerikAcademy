using System;

namespace ExtractBitFromInteger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int numAndMask = num & mask;
            int bit = numAndMask >> p;
            Console.WriteLine(bit);
            Console.ReadKey();
        }
    }
}

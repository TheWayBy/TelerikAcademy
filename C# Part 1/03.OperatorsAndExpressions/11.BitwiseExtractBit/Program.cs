using System;

namespace BitwiseExtractBit
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string nToBit = Convert.ToString(n, 2).PadLeft(16,'0');
            int p = 3;
            int mask = 1 << p;
            int nAndMask = n & mask;
            int bit = nAndMask >> p;
            Console.WriteLine(bit);
            Console.ReadKey();
        }
    }
}

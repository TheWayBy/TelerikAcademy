using System;

namespace CheckABitAtGivenPosition
{
    public class Program
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            p = p--;
            int mask = 1 << p;
            int numAndMask = num & mask;
            int bit = numAndMask >> p;
            if (bit == 1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.ReadKey();
        }
       
    }
}

using System;

namespace PrintLongSequence
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 2; i < 1003; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0}, ", i);
                }
                else
                {
                    Console.Write("{0}, ", -i);
                }
            }
            
            Console.ReadKey();
        }
    }
}

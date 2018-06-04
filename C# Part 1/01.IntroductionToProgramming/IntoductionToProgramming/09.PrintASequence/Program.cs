using System;

namespace PrintASequence
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // TODO: da vidq Emo kak q e napravil
            int i = 1;

            for (i = 2; i <= 10; i++)
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

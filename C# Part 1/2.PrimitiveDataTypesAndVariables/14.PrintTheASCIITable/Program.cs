using System;

namespace PrintTheASCIITable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine((char)i);
            }
            for (int i = 'a'; i < 'Z'; i++)
            {
                Console.WriteLine((char)i);
            }

            Console.ReadKey();
        }
    }
}

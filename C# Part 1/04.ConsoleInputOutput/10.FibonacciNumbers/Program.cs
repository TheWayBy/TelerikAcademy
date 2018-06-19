using System;

namespace FibonacciNumbers
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] fib = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == 1)
                {
                    fib[i] = i;
                    Console.WriteLine(fib[i]);
                    continue;
                }

                fib[i] = fib[i - 1] + fib[i - 2];
                Console.WriteLine(fib[i]);
            }
            Console.ReadLine();
        }
    }
}

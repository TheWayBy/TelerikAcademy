using System;

namespace PrimeNumberCheck
{
    public class Program
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int count = 1;

            for (int i = 1; i < Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }

            if (count >= 2 || num <= 0)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }
            Console.ReadKey();
        }
    }
}

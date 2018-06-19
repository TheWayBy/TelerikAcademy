using System;

namespace NumbersInIntervalDividableByGivenNumber
{
    public class Program
    {
        public static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int count = 0;

            for (int j = num1; j <= num2; j++)
            {
                if (j % 5 == 0)
                {
                    Console.Write("{0} ", j);
                    count++;
                }

                if (count == num3 + 1)
                {
                    break;
                }

            }

            Console.ReadKey();
        }
    }
}

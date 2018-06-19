using System;

namespace SumOfNNumbers
{
   public  class Program
    {
       public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            float sum = 0;
            for (int i = 1; i <= n; i++)
            {
                float numb = float.Parse(Console.ReadLine());
                sum = sum + numb;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}

using System;

namespace SumOfFiveNumbers
{
   public  class Program
    {
        public static void Main()
        {
            string[] nums = Console.ReadLine().Split(' ');
            int sum = 0;

            foreach (string item in nums)
            {
                sum += int.Parse(item);
            }

            Console.WriteLine("sum = {0}", sum);
            Console.ReadKey();
            
        }
    }
}
